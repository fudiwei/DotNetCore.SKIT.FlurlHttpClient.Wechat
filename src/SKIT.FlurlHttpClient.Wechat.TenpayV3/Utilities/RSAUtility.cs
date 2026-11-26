using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// RSA 算法工具类。
    /// </summary>
    public static class RSAUtility
    {
        /// <summary>
        /// 填充模式：OAEPwithSHA-1andMGF1Padding。
        /// </summary>
        public const string PADDING_MODE_OAEPWITHSHA1ANDMGF1 = "OAEPWITHSHA1ANDMGF1PADDING";
        private const string PADDING_MODE_OAEPWITHSHA1ANDMGF1_ALIAS1 = "OAEPPADDING";
        private const string PADDING_MODE_OAEPWITHSHA1ANDMGF1_ALIAS2 = "OAEPWITHSHA-1ANDMGF1PADDING";

        /// <summary>
        /// 填充模式：PKCS1Padding。
        /// </summary>
        public const string PADDING_MODE_PKCS1 = "PKCS1PADDING";
        private const string PADDING_MODE_PKCS1_ALIAS1 = "PKCS1";

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">私钥 DER 字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSHA256(byte[] privateKeyBytes, byte[] messageBytes)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

#if NETCOREAPP || NET5_0_OR_GREATER
            using var rsa = RSA.Create();
            rsa.ImportPkcs8PrivateKey(privateKeyBytes, out _);
#else
            using var rsa = CreateRSA();
            rsa.ImportParameters(Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyParams(privateKeyBytes));
#endif

            return rsa.SignData(messageBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        }

        /// <summary>
        /// 使用私钥基于 SHA-256 算法生成签名。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#1 或 PKCS#8 私钥。</param>
        /// <param name="messageData">待签名的数据。</param>
        /// <returns>经过 Base64 编码的签名。</returns>
        public static EncodedString SignWithSHA256(string privateKeyPem, string messageData)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));

            byte[] privateKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyBytes(privateKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = SignWithSHA256(privateKeyBytes, messageBytes);
            return EncodedString.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">公钥 DER 字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(byte[] publicKeyBytes, byte[] messageBytes, byte[] signBytes)
        {
            if (publicKeyBytes is null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));
            if (signBytes is null) throw new ArgumentNullException(nameof(signBytes));

#if NETCOREAPP || NET5_0_OR_GREATER
            using var rsa = RSA.Create();
            rsa.ImportSubjectPublicKeyInfo(publicKeyBytes, out _);
#else
            using var rsa = CreateRSA();
            rsa.ImportParameters(Shared.Crypto.RSA.RSAKeyReader.ReadPublicKeyParams(publicKeyBytes));
#endif

            if (signBytes.Length != (rsa.KeySize + 7) / 8)
                return false;

            return rsa.VerifyData(messageBytes, signBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="publicKeyPem">PKCS#1 或 PKCS#8/SPKI 公钥。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256(string publicKeyPem, string messageData, EncodedString encodingSignature)
        {
            if (publicKeyPem is null) throw new ArgumentNullException(nameof(publicKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));
            if (encodingSignature.Value is null) throw new ArgumentNullException(nameof(encodingSignature));

            byte[] publicKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPublicKeyBytes(publicKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64);
            return VerifyWithSHA256(publicKeyBytes, messageBytes, signBytes);
        }

        /// <summary>
        /// 使用证书基于 SHA-256 算法验证签名。
        /// </summary>
        /// <param name="certificatePem">PEM 编码的证书。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256ByCertificate(string certificatePem, string messageData, EncodedString encodingSignature)
        {
            if (certificatePem is null) throw new ArgumentNullException(nameof(certificatePem));

            using var x509 = Shared.Crypto.X509Loader.Load(certificatePem);
            byte[] publicKeyBytes = Shared.Crypto.X509Extensions.ExportRSAPublicKeyBytes(x509);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64);
            return VerifyWithSHA256(publicKeyBytes, messageBytes, signBytes);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">私钥 DER 字节数组。</param>
        /// <param name="cipherBytes">待解密的数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_OAEPWITHSHA1ANDMGF1"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] privateKeyBytes, byte[] cipherBytes, string paddingMode = PADDING_MODE_OAEPWITHSHA1ANDMGF1)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

#if NETCOREAPP || NET5_0_OR_GREATER
            using var rsa = RSA.Create();
            rsa.ImportPkcs8PrivateKey(privateKeyBytes, out _);
#else
            using var rsa = CreateRSA();
            rsa.ImportParameters(Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyParams(privateKeyBytes));
#endif

            switch (paddingMode)
            {
                case var s when string.Equals(s, PADDING_MODE_OAEPWITHSHA1ANDMGF1, StringComparison.OrdinalIgnoreCase)
                             || string.Equals(s, PADDING_MODE_OAEPWITHSHA1ANDMGF1_ALIAS1, StringComparison.OrdinalIgnoreCase)
                             || string.Equals(s, PADDING_MODE_OAEPWITHSHA1ANDMGF1_ALIAS2, StringComparison.OrdinalIgnoreCase):
                    return rsa.Decrypt(cipherBytes, RSAEncryptionPadding.OaepSHA1);

                case var s when string.Equals(s, PADDING_MODE_PKCS1, StringComparison.OrdinalIgnoreCase)
                             || string.Equals(s, PADDING_MODE_PKCS1_ALIAS1, StringComparison.OrdinalIgnoreCase):
                    return rsa.Decrypt(cipherBytes, RSAEncryptionPadding.Pkcs1);

                default:
                    throw new NotSupportedException($"Unsupported RSA encryption padding mode: \"{paddingMode}\".");
            }
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#1 或 PKCS#8 私钥。</param>
        /// <param name="encodingCipher">经过编码后的（通常为 Base64）待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_OAEPWITHSHA1ANDMGF1"/>）</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString DecryptWithECB(string privateKeyPem, EncodedString encodingCipher, string paddingMode = PADDING_MODE_OAEPWITHSHA1ANDMGF1)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] privateKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyBytes(privateKeyPem);
            byte[] cipherBytes = EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] plainBytes = DecryptWithECB(privateKeyBytes, cipherBytes, paddingMode);
            return EncodedString.ToLiteralString(plainBytes);
        }

        /// <summary>
        /// 使用公钥基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="publicKeyBytes">公钥 DER 字节数组。</param>
        /// <param name="plainBytes">待加密的数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_OAEPWITHSHA1ANDMGF1"/>）</param>
        /// <returns>加密后的数据字节数组。</returns>
        public static byte[] EncryptWithECB(byte[] publicKeyBytes, byte[] plainBytes, string paddingMode = PADDING_MODE_OAEPWITHSHA1ANDMGF1)
        {
            if (publicKeyBytes is null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (plainBytes is null) throw new ArgumentNullException(nameof(plainBytes));

#if NETCOREAPP || NET5_0_OR_GREATER
            using var rsa = RSA.Create();
            rsa.ImportSubjectPublicKeyInfo(publicKeyBytes, out _);
#else
            using var rsa = CreateRSA();
            rsa.ImportParameters(Shared.Crypto.RSA.RSAKeyReader.ReadPublicKeyParams(publicKeyBytes));
#endif

            switch (paddingMode)
            {
                case var s when string.Equals(s, PADDING_MODE_OAEPWITHSHA1ANDMGF1, StringComparison.OrdinalIgnoreCase)
                             || string.Equals(s, PADDING_MODE_OAEPWITHSHA1ANDMGF1_ALIAS1, StringComparison.OrdinalIgnoreCase)
                             || string.Equals(s, PADDING_MODE_OAEPWITHSHA1ANDMGF1_ALIAS2, StringComparison.OrdinalIgnoreCase):
                    return rsa.Encrypt(plainBytes, RSAEncryptionPadding.OaepSHA1);

                case var s when string.Equals(s, PADDING_MODE_PKCS1, StringComparison.OrdinalIgnoreCase)
                             || string.Equals(s, PADDING_MODE_PKCS1_ALIAS1, StringComparison.OrdinalIgnoreCase):
                    return rsa.Encrypt(plainBytes, RSAEncryptionPadding.Pkcs1);

                default:
                    throw new NotSupportedException($"Unsupported RSA encryption padding mode: \"{paddingMode}\".");
            }
        }

        /// <summary>
        /// 使用公钥基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="publicKeyPem">PKCS#1 或 PKCS#8/SPKI 公钥。</param>
        /// <param name="plainData">待加密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_OAEPWITHSHA1ANDMGF1"/>）</param>
        /// <returns>经过 Base64 编码的加密数据。</returns>
        public static EncodedString EncryptWithECB(string publicKeyPem, string plainData, string paddingMode = PADDING_MODE_OAEPWITHSHA1ANDMGF1)
        {
            if (publicKeyPem is null) throw new ArgumentNullException(nameof(publicKeyPem));
            if (plainData is null) throw new ArgumentNullException(nameof(plainData));

            byte[] publicKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPublicKeyBytes(publicKeyPem);
            byte[] plainBytes = EncodedString.FromLiteralString(plainData);
            byte[] cipherBytes = EncryptWithECB(publicKeyBytes, plainBytes, paddingMode);
            return EncodedString.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// 使用证书基于 ECB 模式加密数据。
        /// </summary>
        /// <param name="certificatePem">PEM 编码的证书。</param>
        /// <param name="plainData">待加密的数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_OAEPWITHSHA1ANDMGF1"/>）</param>
        /// <returns>经过 Base64 编码的加密数据。</returns>
        public static EncodedString EncryptWithECBByCertificate(string certificatePem, string plainData, string paddingMode = PADDING_MODE_OAEPWITHSHA1ANDMGF1)
        {
            if (certificatePem is null) throw new ArgumentNullException(nameof(certificatePem));

            using var x509 = Shared.Crypto.X509Loader.Load(certificatePem);
            byte[] publicKeyBytes = Shared.Crypto.X509Extensions.ExportRSAPublicKeyBytes(x509);
            byte[] plainBytes = EncodedString.FromLiteralString(plainData);
            byte[] cipherBytes = EncryptWithECB(publicKeyBytes, plainBytes, paddingMode);
            return EncodedString.ToBase64String(cipherBytes);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出 PKCS#8/SPKI 公钥。</para>
        /// <para>即从 "-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----" 转为 "-----BEGIN PUBLIC KEY----- ..... -----END PUBLIC KEY-----"。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>PKCS#8/SPKI 公钥。</returns>
        public static string ExportPublicKeyFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            byte[] publicKeyBytes = Shared.Crypto.X509Extensions.ExportRSAPublicKeyBytes(x509);
            return Shared.Crypto.PemWriter.ToString("PUBLIC KEY", publicKeyBytes, true);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书序列号。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>证书序列号。</returns>
        public static string ExportSerialNumberFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            return x509.SerialNumber;
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书有效期的开始时间。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>证书有效期的开始时间。</returns>
        public static DateTimeOffset ExportValidFromDateFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            return new DateTimeOffset(x509.NotBefore);
        }

        /// <summary>
        /// <para>从 CRT/CER 证书中导出证书有效期的结束时间。</para>
        /// </summary>
        /// <param name="certificate">PEM 编码的证书。</param>
        /// <returns>证书有效期的结束时间。</returns>
        public static DateTimeOffset ExportValidToDateFromCertificate(string certificate)
        {
            if (certificate is null) throw new ArgumentNullException(nameof(certificate));

            using var x509 = Shared.Crypto.X509Loader.Load(certificate);
            return new DateTimeOffset(x509.NotAfter);
        }

#if !NETCOREAPP && !NET5_0_OR_GREATER
        private static RSA CreateRSA()
        {
#if NETFRAMEWORK
            return new RSACng();
#else
            RSA rsa = RSA.Create();
            if (rsa is RSACryptoServiceProvider)
            {
                // .NET Framework's default CSP cannot perform OAEP; use its built-in CNG provider.
                rsa.Dispose();

                Type? rsaCngType = typeof(RSA).Assembly.GetType("System.Security.Cryptography.RSACng");
                if (rsaCngType is null)
                    throw new PlatformNotSupportedException();
                return (RSA)Activator.CreateInstance(rsaCngType)!;
            }
            return rsa;
#endif
        }
#endif
    }
}
