using System;
using System.IO;
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
        // REF: https://github.com/bcgit/bc-csharp/blob/master/crypto/src/security/CipherUtilities.cs
        private const string RSA_CIPHER_ALG = "RSA/ECB/OAEPWITHSHA1ANDMGF1PADDING";
        // REF: https://github.com/bcgit/bc-csharp/blob/master/crypto/src/security/SignerUtilities.cs
        private const string RSA_SIGNER_ALG = "SHA-256withRSA";

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="plainBytes">待签名的数据字节数组。</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSHA256(byte[] privateKeyBytes, byte[] plainBytes)
        {
            if (privateKeyBytes == null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            RsaKeyParameters rsaKeyParams = (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
            return SignWithSHA256(rsaKeyParams, plainBytes);
        }

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="plainText">待签名的文本数据。</param>
        /// <returns>经 Base64 编码的签名。</returns>
        public static string SignWithSHA256(string privateKey, string plainText)
        {
            if (privateKey == null) throw new ArgumentNullException(nameof(privateKey));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            byte[] privateKeyBytes = ConvertPkcs8PrivateKeyToByteArray(privateKey);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] signBytes = SignWithSHA256(privateKeyBytes, plainBytes);
            return Convert.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="plainBytes">待验证的数据字节数据。</param>
        /// <param name="signBytes">待验证的签名字节数据。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(byte[] publicKeyBytes, byte[] plainBytes, byte[] signBytes)
        {
            if (publicKeyBytes == null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));
            if (signBytes == null) throw new ArgumentNullException(nameof(signBytes));

            RsaKeyParameters rsaKeyParams = (RsaKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
            return VerifyWithSHA256(rsaKeyParams, plainBytes, signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="plainText">待验证的文本数据。</param>
        /// <param name="signature">经 Base64 编码的待验证的签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(string publicKey, string plainText, string signature)
        {
            if (publicKey == null) throw new ArgumentNullException(nameof(publicKey));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            byte[] publicKeyBytes = ConvertPkcs8PublicKeyToByteArray(publicKey);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] signBytes = Convert.FromBase64String(signature);
            return VerifyWithSHA256(publicKeyBytes, plainBytes, signBytes);
        }

        /// <summary>
        /// 使用证书基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <param name="plainText">待验证的文本数据。</param>
        /// <param name="signature">经 Base64 编码的待验证的签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256ByCertificate(string certificate, string plainText, string signature)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));
            if (signature == null) throw new ArgumentNullException(nameof(signature));

            RsaKeyParameters rsaKeyParams = ConvertCertificateToPublicKeyParams(certificate);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] signBytes = Convert.FromBase64String(signature);
            return VerifyWithSHA256(rsaKeyParams, plainBytes, signBytes);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数据。</param>
        /// <param name="cipherBytes">待解密的数据字节数据。</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] privateKeyBytes, byte[] cipherBytes)
        {
            if (privateKeyBytes == null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            RsaKeyParameters rsaKeyParams = (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
            return DecryptWithECB(rsaKeyParams, cipherBytes);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKey">PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="cipherText">经 Base64 编码的待解密数据。</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithECB(string privateKey, string cipherText)
        {
            if (privateKey == null) throw new ArgumentNullException(nameof(privateKey));
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));

            byte[] privateKeyBytes = ConvertPkcs8PrivateKeyToByteArray(privateKey);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] plainBytes = DecryptWithECB(privateKeyBytes, cipherBytes);
            return Encoding.UTF8.GetString(plainBytes);
        }

        /// <summary>
        /// 使用公钥基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="publicKeyBytes">PKCS#8 公钥字节数据。</param>
        /// <param name="plainBytes">待加密的数据字节数据。</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptWithECB(byte[] publicKeyBytes, byte[] plainBytes)
        {
            if (publicKeyBytes == null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (plainBytes == null) throw new ArgumentNullException(nameof(plainBytes));

            RsaKeyParameters rsaKeyParams = (RsaKeyParameters)PublicKeyFactory.CreateKey(publicKeyBytes);
            return EncryptWithECB(rsaKeyParams, plainBytes);
        }

        /// <summary>
        /// 使用公钥基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="publicKey">PKCS#8 公钥（PEM 格式）。</param>
        /// <param name="plainText">待加密的文本数据。</param>
        /// <returns>经 Base64 编码的加密数据。</returns>
        public static string EncryptWithECB(string publicKey, string plainText)
        {
            if (publicKey == null) throw new ArgumentNullException(nameof(publicKey));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            byte[] publicKeyBytes = ConvertPkcs8PublicKeyToByteArray(publicKey);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = EncryptWithECB(publicKeyBytes, plainBytes);
            return Convert.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// 使用证书基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <param name="plainText">待加密的文本数据。</param>
        /// <returns>经 Base64 编码的加密数据。</returns>
        public static string EncryptWithECBByCertificate(string certificate, string plainText)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));
            if (plainText == null) throw new ArgumentNullException(nameof(plainText));

            RsaKeyParameters rsaKeyParams = ConvertCertificateToPublicKeyParams(certificate);
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] cipherBytes = EncryptWithECB(rsaKeyParams, plainBytes);
            return Convert.ToBase64String(cipherBytes);
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
        public static string ExportPublicKey(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            using (TextWriter swriter = new StringWriter())
            {
                RsaKeyParameters rsaKeyParams = ConvertCertificateToPublicKeyParams(certificate);
                PemWriter pemWriter = new PemWriter(swriter);
                pemWriter.WriteObject(rsaKeyParams);
                pemWriter.Writer.Flush();
                return swriter.ToString()!;
            }
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书序列号。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书序列号。</returns>
        public static string ExportSerialNumber(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate cert = ParseX509Certificate(certificate);
            return cert.SerialNumber.ToString(16);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书颁发时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书颁发时间。</returns>
        public static DateTimeOffset ExportEffectiveTime(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate cert = ParseX509Certificate(certificate);
            return new DateTimeOffset(cert.NotBefore);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书过期时间。</para>
        /// </summary>
        /// <param name="certificate">证书（PEM 格式）。</param>
        /// <returns>证书过期时间。</returns>
        public static DateTimeOffset ExportExpireTime(string certificate)
        {
            if (certificate == null) throw new ArgumentNullException(nameof(certificate));

            X509Certificate cert = ParseX509Certificate(certificate);
            return new DateTimeOffset(cert.NotAfter);
        }

        private static byte[] ConvertPkcs8PrivateKeyToByteArray(string privateKey)
        {
            privateKey = privateKey
                .Replace("-----BEGIN PRIVATE KEY-----", "")
                .Replace("-----END PRIVATE KEY-----", "");
            privateKey = Regex.Replace(privateKey, "\\s+", "");
            return Convert.FromBase64String(privateKey);
        }

        private static byte[] ConvertPkcs8PublicKeyToByteArray(string publicKey)
        {
            publicKey = publicKey
                .Replace("-----BEGIN PUBLIC KEY-----", "")
                .Replace("-----END PUBLIC KEY-----", "");
            publicKey = Regex.Replace(publicKey, "\\s+", "");
            return Convert.FromBase64String(publicKey);
        }

        private static X509Certificate ParseX509Certificate(string certificate)
        {
            using (TextReader sreader = new StringReader(certificate))
            {
                PemReader pemReader = new PemReader(sreader);
                return (X509Certificate)pemReader.ReadObject();
            }
        }

        private static RsaKeyParameters ConvertCertificateToPublicKeyParams(string certificate)
        {
            X509Certificate cert = ParseX509Certificate(certificate);
            return (RsaKeyParameters)cert.GetPublicKey();
        }

        private static byte[] SignWithSHA256(RsaKeyParameters rsaKeyParams, byte[] plainBytes)
        {
            ISigner signer = SignerUtilities.GetSigner(RSA_SIGNER_ALG);
            signer.Init(true, rsaKeyParams);
            signer.BlockUpdate(plainBytes, 0, plainBytes.Length);
            return signer.GenerateSignature();
        }

        private static bool VerifyWithSHA256(RsaKeyParameters rsaKeyParams, byte[] plainBytes, byte[] signBytes)
        {
            ISigner signer = SignerUtilities.GetSigner(RSA_SIGNER_ALG);
            signer.Init(false, rsaKeyParams);
            signer.BlockUpdate(plainBytes, 0, plainBytes.Length);
            return signer.VerifySignature(signBytes);
        }

        private static byte[] EncryptWithECB(RsaKeyParameters rsaKeyParams, byte[] plainBytes)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher(RSA_CIPHER_ALG);
            cipher.Init(true, rsaKeyParams);
            return cipher.DoFinal(plainBytes);
        }

        private static byte[] DecryptWithECB(RsaKeyParameters rsaKeyParams, byte[] cipherBytes)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher(RSA_CIPHER_ALG);
            cipher.Init(false, rsaKeyParams);
            return cipher.DoFinal(cipherBytes);
        }
    }
}
