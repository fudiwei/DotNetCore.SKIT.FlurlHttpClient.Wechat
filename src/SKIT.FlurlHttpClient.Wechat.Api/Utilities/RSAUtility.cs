using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// RSA 算法工具类。
    /// </summary>
    public static class RSAUtility
    {
        /// <summary>
        /// 使用私钥基于 SHA-256/PSS 算法生成签名。
        /// </summary>
        /// <param name="privateKeyBytes">私钥 DER 字节数组。</param>
        /// <param name="messageBytes">待签名的数据字节数组。</param>
        /// <returns>签名字节数组。</returns>
        public static byte[] SignWithSHA256PSS(byte[] privateKeyBytes, byte[] messageBytes)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

#if NETCOREAPP || NET5_0_OR_GREATER
            using var rsa = RSA.Create();
            rsa.ImportPkcs8PrivateKey(privateKeyBytes, out _);
#else
            using var rsa = CreateRSA();
            var rsaParams = Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyParams(privateKeyBytes);
            rsa.ImportParameters(rsaParams);
#endif

            return rsa.SignData(messageBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pss);
        }

        /// <summary>
        /// 使用私钥基于 SHA-256/PSS 算法生成签名。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#1 或 PKCS#8 私钥。</param>
        /// <param name="messageData">待签名的数据。</param>
        /// <returns>经过 Base64 编码的签名。</returns>
        public static EncodedString SignWithSHA256PSS(string privateKeyPem, string messageData)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));

            byte[] privateKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyBytes(privateKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = SignWithSHA256PSS(privateKeyBytes, messageBytes);
            return EncodedString.ToBase64String(signBytes);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256/PSS 算法验证签名。
        /// </summary>
        /// <param name="publicKeyBytes">公钥 DER 字节数组。</param>
        /// <param name="messageBytes">待验证的数据字节数组。</param>
        /// <param name="signBytes">签名字节数组。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256PSS(byte[] publicKeyBytes, byte[] messageBytes, byte[] signBytes)
        {
            if (publicKeyBytes is null) throw new ArgumentNullException(nameof(publicKeyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));
            if (signBytes is null) throw new ArgumentNullException(nameof(signBytes));

#if NETCOREAPP || NET5_0_OR_GREATER
            using var rsa = RSA.Create();
            rsa.ImportSubjectPublicKeyInfo(publicKeyBytes, out _);
#else
            using var rsa = CreateRSA();
            var rsaParams = Shared.Crypto.RSA.RSAKeyReader.ReadPublicKeyParams(publicKeyBytes);
            rsa.ImportParameters(rsaParams);
#endif

            if (signBytes.Length != (rsa.KeySize + 7) / 8)
                return false;

            return rsa.VerifyData(messageBytes, signBytes, HashAlgorithmName.SHA256, RSASignaturePadding.Pss);
        }

        /// <summary>
        /// 使用公钥基于 SHA-256/PSS 算法验证签名。
        /// </summary>
        /// <param name="publicKeyPem">PKCS#1 或 PKCS#8/SPKI 公钥。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256PSS(string publicKeyPem, string messageData, EncodedString encodingSignature)
        {
            if (publicKeyPem is null) throw new ArgumentNullException(nameof(publicKeyPem));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));
            if (encodingSignature.Value is null) throw new ArgumentNullException(nameof(encodingSignature));

            byte[] publicKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPublicKeyBytes(publicKeyPem);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64);
            return VerifyWithSHA256PSS(publicKeyBytes, messageBytes, signBytes);
        }

        /// <summary>
        /// 使用证书基于 SHA-256/PSS 算法验证签名。
        /// </summary>
        /// <param name="certificatePem">PEM 编码的证书。</param>
        /// <param name="messageData">待验证的数据。</param>
        /// <param name="encodingSignature">经过编码后的（通常为 Base64）签名。</param>
        /// <returns>验证结果。</returns>
        public static bool VerifyWithSHA256PSSByCertificate(string certificatePem, string messageData, EncodedString encodingSignature)
        {
            if (certificatePem is null) throw new ArgumentNullException(nameof(certificatePem));

            using var x509 = Shared.Crypto.X509Loader.Load(certificatePem);
            byte[] publicKeyBytes = Shared.Crypto.X509Extensions.ExportRSAPublicKeyBytes(x509);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] signBytes = EncodedString.FromString(encodingSignature, fallbackEncodingKind: EncodingKinds.Base64);
            return VerifyWithSHA256PSS(publicKeyBytes, messageBytes, signBytes);
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

#if !NETCOREAPP && !NET5_0_OR_GREATER
        private static RSA CreateRSA()
        {
#if NETFRAMEWORK
            return new RSACng();
#else
            RSA rsa = RSA.Create();
            if (rsa is RSACryptoServiceProvider)
            {
                // .NET Framework's default CSP cannot perform PSS; use its built-in CNG provider.
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
