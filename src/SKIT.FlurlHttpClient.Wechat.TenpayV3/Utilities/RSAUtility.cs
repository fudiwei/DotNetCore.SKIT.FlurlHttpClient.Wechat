using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.X509;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    /// <summary>
    /// RSA 算法工具类。
    /// </summary>
    public static class RSAUtility
    {
        private const string RSA_CIPHER_ALGORITHM_ECB = "RSA/ECB";
        private const string RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1 = "OAEPWITHSHA1ANDMGF1PADDING";
        private const string RSA_SIGNER_ALGORITHM_SHA256 = "SHA-256withRSA";

        private static byte[] ConvertPrivateKeyPkcs8PemToByteArray(string privateKey)
        {
            privateKey = privateKey
                .Replace("-----BEGIN PRIVATE KEY-----", string.Empty)
                .Replace("-----END PRIVATE KEY-----", string.Empty);
            privateKey = Regex.Replace(privateKey, "\\s+", string.Empty);
            return Convert.FromBase64String(privateKey);
        }

        private static byte[] ConvertPublicKeyPkcs8PemToByteArray(string publicKey)
        {
            publicKey = publicKey
                .Replace("-----BEGIN PUBLIC KEY-----", string.Empty)
                .Replace("-----END PUBLIC KEY-----", string.Empty);
            publicKey = Regex.Replace(publicKey, "\\s+", string.Empty);
            return Convert.FromBase64String(publicKey);
        }

        private static X509Certificate ParseCertificatePemToX509(string certificate)
        {
            using (TextReader sreader = new StringReader(certificate))
            {
                PemReader pemReader = new PemReader(sreader);
                return (X509Certificate)pemReader.ReadObject();
            }
        }

        private static RsaKeyParameters ParsePrivateKeyPemToPublicKeyParameters(byte[] privateKeyBytes)
        {
            return (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
        }

        private static RsaKeyParameters ParsePublicKeyPemToPublicKeyParameters(byte[] publicKeyBytes)
        {
            return (RsaKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
        }

        private static byte[] SignWithSHA256(RsaKeyParameters rsaPrivateKeyParams, byte[] msgBytes)
        {
            ISigner signer = SignerUtilities.GetSigner(RSA_SIGNER_ALGORITHM_SHA256);
            signer.Init(true, rsaPrivateKeyParams);
            signer.BlockUpdate(msgBytes, 0, msgBytes.Length);
            return signer.GenerateSignature();
        }

        private static bool VerifyWithSHA256(RsaKeyParameters rsaPublicKeyParams, byte[] msgBytes, byte[] signBytes)
        {
            ISigner signer = SignerUtilities.GetSigner(RSA_SIGNER_ALGORITHM_SHA256);
            signer.Init(false, rsaPublicKeyParams);
            signer.BlockUpdate(msgBytes, 0, msgBytes.Length);
            return signer.VerifySignature(signBytes);
        }

        private static byte[] DecryptWithECB(RsaKeyParameters rsaPrivateKeyParams, byte[] cipherBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"{RSA_CIPHER_ALGORITHM_ECB}/{paddingMode}");
            cipher.Init(false, rsaPrivateKeyParams);
            return cipher.DoFinal(cipherBytes);
        }

        private static byte[] EncryptWithECB(RsaKeyParameters rsaPublicKeyParams, byte[] plainBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"{RSA_CIPHER_ALGORITHM_ECB}/{paddingMode}");
            cipher.Init(true, rsaPublicKeyParams);
            return cipher.DoFinal(plainBytes);
        }

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="msgBytes">待签名的数据字节数组。</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSHA256(byte[] privateKeyBytes, byte[] msgBytes)
        {
            if (privateKeyBytes == null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));

            RsaKeyParameters rsaPrivateKeyParams = ParsePrivateKeyPemToPublicKeyParameters(privateKeyBytes);
            return SignWithSHA256(rsaPrivateKeyParams, msgBytes);
        }

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="message">待签名的文本数据。</param>
        /// <returns>经 Base64 编码的签名。</returns>
        public static string SignWithSHA256(string privateKey, string message)
        {
            if (privateKey == null) throw new ArgumentNullException(nameof(privateKey));
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] privateKeyBytes = ConvertPrivateKeyPkcs8PemToByteArray(privateKey);
            byte[] msgBytes = Encoding.UTF8.GetBytes(message);
            byte[] signBytes = SignWithSHA256(privateKeyBytes, msgBytes);
            return Convert.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="msgBytes">待验证的数据字节数据。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(byte[] publicKeyBytes, byte[] msgBytes, byte[] signBytes)
        {
            if (publicKeyBytes == null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));
            if (signBytes == null) throw new ArgumentNullException(nameof(signBytes));

            RsaKeyParameters rsaPublicKeyParams = ParsePublicKeyPemToPublicKeyParameters(publicKeyBytes);
            return VerifyWithSHA256(rsaPublicKeyParams, msgBytes, signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="message">待验证的文本数据。</param>
        /// <param name="signature">经 Base64 编码的待验证的签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(string publicKey, string message, string signature)
        {
            if (publicKey == null) throw new ArgumentNullException(nameof(publicKey));
            if (message == null) throw new ArgumentNullException(nameof(message));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            byte[] publicKeyBytes = ConvertPublicKeyPkcs8PemToByteArray(publicKey);
            byte[] msgBytes = Encoding.UTF8.GetBytes(message);
            byte[] signBytes = Convert.FromBase64String(signature);
            return VerifyWithSHA256(publicKeyBytes, msgBytes, signBytes);
        }

        /// <summary>
        /// 使用证书基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <param name="message">待验证的文本数据。</param>
        /// <param name="signature">经 Base64 编码的待验证的签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256ByCertificate(string certificate, string message, string signature)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            string publicKey = ExportPublicKeyFromCertificate(certificate);
            return VerifyWithSHA256(publicKey, message, signature);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数据。</param>
        /// <param name="cipherBytes">待解密的数据字节数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] privateKeyBytes, byte[] cipherBytes, string paddingMode = RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1)
        {
            if (privateKeyBytes == null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            RsaKeyParameters rsaPrivateKeyParams = ParsePrivateKeyPemToPublicKeyParameters(privateKeyBytes);
            return DecryptWithECB(rsaPrivateKeyParams, cipherBytes, paddingMode);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="cipherText">经 Base64 编码的待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1"/>）</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithECB(string privateKey, string cipherText, string paddingMode = RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1)
        {
            if (privateKey == null) throw new ArgumentNullException(nameof(privateKey));
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));

            byte[] privateKeyBytes = ConvertPrivateKeyPkcs8PemToByteArray(privateKey);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] plainBytes = DecryptWithECB(privateKeyBytes, cipherBytes, paddingMode);
            return Encoding.UTF8.GetString(plainBytes);
        }

        /// <summary>
        /// 使用公钥基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="plainBytes">待加密的数据字节数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1"/>）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptWithECB(byte[] publicKeyBytes, byte[] plainBytes, string paddingMode = RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1)
        {
            if (publicKeyBytes == null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            RsaKeyParameters rsaPublicKeyParams = ParsePublicKeyPemToPublicKeyParameters(publicKeyBytes);
            return EncryptWithECB(rsaPublicKeyParams, plainBytes, paddingMode);
        }

        /// <summary>
        /// 使用公钥基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="plainText">待加密的文本数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1"/>）</param>
        /// <returns>经 Base64 编码的加密数据。</returns>
        public static string EncryptWithECB(string publicKey, string plainText, string paddingMode = RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1)
        {
            if (publicKey == null) throw new ArgumentNullException(nameof(publicKey));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            byte[] publicKeyBytes = ConvertPublicKeyPkcs8PemToByteArray(publicKey);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = EncryptWithECB(publicKeyBytes, plainBytes, paddingMode);
            return Convert.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// 使用证书基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <param name="plainText">待加密的文本数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1"/>）</param>
        /// <returns>经 Base64 编码的加密数据。</returns>
        public static string EncryptWithECBByCertificate(string certificate, string plainText, string paddingMode = RSA_CIPHER_PADDING_OAEP_WITH_SHA1_AND_MGF1)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            string publicKey = ExportPublicKeyFromCertificate(certificate);
            return EncryptWithECB(publicKey, plainText, paddingMode);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出 PKCS#8 公钥。</para>
        /// <para>
        ///     即从 -----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----
        ///     转为 -----BEGIN PUBLIC KEY----- ..... -----END PUBLIC KEY-----
        /// </para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>PKCS#8 公钥（PEM 格式）。</returns>
        public static string ExportPublicKeyFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            using (TextWriter swriter = new StringWriter())
            {
                X509Certificate x509cert = ParseCertificatePemToX509(certificate);
                RsaKeyParameters rsaPublicKeyParams = (RsaKeyParameters)x509cert.GetPublicKey();
                PemWriter pemWriter = new PemWriter(swriter);
                pemWriter.WriteObject(rsaPublicKeyParams);
                pemWriter.Writer.Flush();
                return swriter.ToString()!;
            }
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书序列号。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书序列号。</returns>
        public static string ExportSerialNumberFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate x509cert = ParseCertificatePemToX509(certificate);
            return x509cert.SerialNumber.ToString(16);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书颁发时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书颁发时间。</returns>
        public static DateTimeOffset ExportEffectiveTimeFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate x509cert = ParseCertificatePemToX509(certificate);
            return new DateTimeOffset(x509cert.NotBefore);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书过期时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书过期时间。</returns>
        public static DateTimeOffset ExportExpireTimeFromCertificate(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate x509cert = ParseCertificatePemToX509(certificate);
            return new DateTimeOffset(x509cert.NotAfter);
        }
    }
}
