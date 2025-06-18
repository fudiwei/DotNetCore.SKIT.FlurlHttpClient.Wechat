using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

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

        private static byte[] ConvertPrivateKeyPemToByteArray(string privateKeyPem)
        {
            const string PKCS8_HEADER = "-----BEGIN PRIVATE KEY-----";
            const string PKCS8_FOOTER = "-----END PRIVATE KEY-----";

            if (!privateKeyPem.StartsWith(PKCS8_HEADER))
            {
                using (TextReader textReader = new StringReader(privateKeyPem))
                using (PemReader pemReader = new PemReader(textReader))
                {
                    object pemObject = pemReader.ReadObject();

                    if (pemObject is AsymmetricCipherKeyPair)
                    {
                        // PKCS#1 格式
                        AsymmetricCipherKeyPair cipherKeyPair = (AsymmetricCipherKeyPair)pemObject;
                        using (TextWriter textWriter = new StringWriter())
                        using (PemWriter pemWriter = new PemWriter(textWriter))
                        {
                            Pkcs8Generator pkcs8 = new Pkcs8Generator(cipherKeyPair.Private);
                            pemWriter.WriteObject(pkcs8);
                            pemWriter.Writer.Close();

                            privateKeyPem = textWriter.ToString()!;
                        }
                    }
                    else if (pemObject is RsaPrivateCrtKeyParameters)
                    {
                        // PKCS#8 格式
                    }
                    else
                    {
                        throw new NotSupportedException("Private key format is not supported.");
                    }
                }
            }

            privateKeyPem = privateKeyPem
                .Replace(PKCS8_HEADER, string.Empty)
                .Replace(PKCS8_FOOTER, string.Empty);
            privateKeyPem = Regex.Replace(privateKeyPem, "\\s+", string.Empty);
            return Convert.FromBase64String(privateKeyPem);
        }

        private static byte[] DecryptWithECB(RsaKeyParameters rsaPrivateKeyParams, byte[] cipherBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"RSA/ECB/{paddingMode}");
            cipher.Init(false, rsaPrivateKeyParams);
            return cipher.DoFinal(cipherBytes);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#8 私钥字节数组。</param>
        /// <param name="cipherBytes">待解密的数据字节数组。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS1"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] privateKeyBytes, byte[] cipherBytes, string paddingMode = PADDING_MODE_PKCS1)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

#if NET5_0_OR_GREATER
            if (string.Equals(paddingMode, PADDING_MODE_PKCS1, StringComparison.OrdinalIgnoreCase))
            {
                using (RSA rsa = RSA.Create())
                {
                    rsa.ImportPkcs8PrivateKey(privateKeyBytes, out _);
                    return rsa.Decrypt(cipherBytes, RSAEncryptionPadding.Pkcs1);
                }
            }
#endif

            RsaKeyParameters rsaPrivateKeyParams = (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
            return DecryptWithECB(rsaPrivateKeyParams, cipherBytes, paddingMode);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyPem">PKCS#1/PKCS#8 私钥（PEM 格式）。</param>
        /// <param name="encodingCipher">经过编码后的（通常为 Base64）待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="PADDING_MODE_PKCS1"/>）</param>
        /// <returns>解密后的数据。</returns>
        public static EncodedString DecryptWithECB(string privateKeyPem, EncodedString encodingCipher, string paddingMode = PADDING_MODE_PKCS1)
        {
            if (privateKeyPem is null) throw new ArgumentNullException(nameof(privateKeyPem));
            if (encodingCipher.Value is null) throw new ArgumentNullException(nameof(encodingCipher));

            byte[] privateKeyBytes = ConvertPrivateKeyPemToByteArray(privateKeyPem);
            byte[] cipherBytes = EncodedString.FromString(encodingCipher, fallbackEncodingKind: EncodingKinds.Base64);
            byte[] plainBytes = DecryptWithECB(privateKeyBytes, cipherBytes, paddingMode);
            return EncodedString.ToLiteralString(plainBytes);
        }
    }
}
