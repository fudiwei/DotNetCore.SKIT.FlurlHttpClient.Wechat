using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// RSA 算法工具类。
    /// </summary>
    public static class RSAUtility
    {
        /// <summary>
        /// 填充模式：PKCS1Padding。
        /// </summary>
        public const string PADDING_MODE_PKCS1 = "PKCS1PADDING";
        private const string PADDING_MODE_PKCS1_ALIAS1 = "PKCS1";

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">私钥 DER 字节数组。</param>
        /// <param name="cipherBytes">待解密的数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS1"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] privateKeyBytes, byte[] cipherBytes, string paddingMode = PADDING_MODE_PKCS1)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

#if NETCOREAPP || NET5_0_OR_GREATER
            using var rsa = RSA.Create();
            rsa.ImportPkcs8PrivateKey(privateKeyBytes, out _);
#else
            using var rsa = CreateRSA();
            var rsaParams = Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyParams(privateKeyBytes);
            rsa.ImportParameters(rsaParams);
#endif

            switch (paddingMode)
            {
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
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS1"/>）</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString DecryptWithECB(string privateKeyPem, EncodedString encodingCipher, string paddingMode = PADDING_MODE_PKCS1)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] privateKeyBytes = Shared.Crypto.RSA.RSAKeyReader.ReadPrivateKeyBytes(privateKeyPem);
            byte[] cipherBytes = EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] plainBytes = DecryptWithECB(privateKeyBytes, cipherBytes, paddingMode);
            return EncodedString.ToLiteralString(plainBytes);
        }

#if !NETCOREAPP && !NET5_0_OR_GREATER
        private static RSA CreateRSA()
        {
#if NETFRAMEWORK
            return new RSACng();
#else
            return RSA.Create();
#endif
        }
#endif
    }
}
