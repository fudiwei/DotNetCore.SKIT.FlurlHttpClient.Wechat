using System;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    /// <summary>
    /// AES 算法工具类。
    /// </summary>
    public static class AESUtility
    {
        /// <summary>
        /// 基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithECB(byte[] keyBytes, byte[] cipherBytes)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (cipherBytes is null) throw new ArgumentNullException(nameof(cipherBytes));

            using (SymmetricAlgorithm aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = keyBytes;

                using ICryptoTransform transform = aes.CreateDecryptor();
                return transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
            }
        }

        /// <summary>
        /// 基于 ECB 模式解密数据。
        /// </summary>
        /// <param name="encodingKey">经 Base64 编码后的 AES 密钥。</param>
        /// <param name="encodingCipherText">经 Base64 编码后的待解密数据。</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithECB(string encodingKey, string encodingCipherText)
        {
            if (encodingKey is null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingCipherText is null) throw new ArgumentNullException(nameof(encodingCipherText));

            byte[] plainBytes = DecryptWithECB(
                keyBytes: Convert.FromBase64String(encodingKey),
                cipherBytes: Convert.FromBase64String(encodingCipherText)
            );
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
