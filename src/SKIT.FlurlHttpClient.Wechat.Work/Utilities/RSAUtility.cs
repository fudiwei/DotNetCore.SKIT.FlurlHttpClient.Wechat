using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
{
    /// <summary>
    /// RSA 算法工具类。
    /// </summary>
    public static class RSAUtility
    {
        private const string RSA_CIPHER_ALGORITHM_NONE = "RSA/ECB";
        private const string RSA_CIPHER_PADDING_PKCS1 = "PKCS1PADDING";

        private static byte[] ConvertPrivateKeyPkcs1PemToByteArray(string privateKey)
        {
            using (TextReader textReader = new StringReader(privateKey))
            using (PemReader pemReader = new PemReader(textReader))
            {
                AsymmetricCipherKeyPair cipherKeyPair = (AsymmetricCipherKeyPair)pemReader.ReadObject();
                using (TextWriter textWriter = new StringWriter())
                using (PemWriter pemWriter = new PemWriter(textWriter))
                {
                    Pkcs8Generator pkcs8 = new Pkcs8Generator(cipherKeyPair.Private);
                    pemWriter.WriteObject(pkcs8);
                    pemWriter.Writer.Close();

                    privateKey = textWriter.ToString()!;
                    privateKey = privateKey
                        .Replace("-----BEGIN PRIVATE KEY-----", string.Empty)
                        .Replace("-----END PRIVATE KEY-----", string.Empty);
                    privateKey = Regex.Replace(privateKey, "\\s+", string.Empty);
                    return Convert.FromBase64String(privateKey);
                }
            }
        }

        private static RsaKeyParameters ParsePrivateKeyPemToPrivateKeyParameters(byte[] privateKeyBytes)
        {
            return (RsaKeyParameters)PrivateKeyFactory.CreateKey(privateKeyBytes);
        }

        private static byte[] DecryptWithECB(RsaKeyParameters rsaPrivateKeyParams, byte[] cipherBytes, string paddingMode)
        {
            IBufferedCipher cipher = CipherUtilities.GetCipher($"{RSA_CIPHER_ALGORITHM_NONE}/{paddingMode}");
            cipher.Init(false, rsaPrivateKeyParams);
            return cipher.DoFinal(cipherBytes);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKeyBytes">PKCS#1 私钥字节数据。</param>
        /// <param name="cipherBytes">待解密的数据字节数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="RSA_CIPHER_PADDING_PKCS1"/>）</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] privateKeyBytes, byte[] cipherBytes, string paddingMode = RSA_CIPHER_PADDING_PKCS1)
        {
            if (privateKeyBytes is null) throw new ArgumentNullException(nameof(privateKeyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

            RsaKeyParameters rsaPrivateKeyParams = ParsePrivateKeyPemToPrivateKeyParameters(privateKeyBytes);
            return DecryptWithECB(rsaPrivateKeyParams, cipherBytes, paddingMode);
        }

        /// <summary>
        /// 使用私钥基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="privateKey">PKCS#1 私钥（PEM 格式）。</param>
        /// <param name="cipherText">经 Base64 编码的待解密数据。</param>
        /// <param name="paddingMode">填充模式。（默认值：<see cref="RSA_CIPHER_PADDING_PKCS1"/>）</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithECB(string privateKey, string cipherText, string paddingMode = RSA_CIPHER_PADDING_PKCS1)
        {
            if (privateKey is null) throw new ArgumentNullException(nameof(privateKey));
            if (cipherText is null) throw new ArgumentNullException(nameof(cipherText));

            byte[] privateKeyBytes = ConvertPrivateKeyPkcs1PemToByteArray(privateKey);
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            byte[] plainBytes = DecryptWithECB(privateKeyBytes, cipherBytes, paddingMode);
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
