using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
{
    public static class AESUtility
    {
        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="ivBytes">加密使用的初始化向量字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithCBC(byte[] keyBytes, byte[] ivBytes, byte[] cipherBytes)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes == null) throw new ArgumentNullException(nameof(ivBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            using (SymmetricAlgorithm aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = keyBytes;
                aes.IV = ivBytes;

                using ICryptoTransform transform = aes.CreateDecryptor();
                return transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
            }
        }

        /// <summary>
        /// 基于 CBC 模式解密数据。
        /// </summary>
        /// <param name="encodingKey">经 Base64 编码后的 AES 密钥。</param>
        /// <param name="encodingIV">经 Base64 编码后的 AES 初始化向量。</param>
        /// <param name="encodingCipherText">经 Base64 编码后的待解密数据。</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithCBC(string encodingKey, string encodingIV, string encodingCipherText)
        {
            if (encodingKey == null) throw new ArgumentNullException(nameof(encodingKey));
            if (encodingCipherText == null) throw new ArgumentNullException(nameof(encodingCipherText));

            byte[] plainBytes = DecryptWithCBC(
                keyBytes: Convert.FromBase64String(encodingKey),
                ivBytes: Convert.FromBase64String(encodingIV),
                cipherBytes: Convert.FromBase64String(encodingCipherText)
            );
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
