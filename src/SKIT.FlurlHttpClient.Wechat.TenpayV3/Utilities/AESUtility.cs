using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    /// <summary>
    /// AES 算法工具类。
    /// </summary>
    public static class AESUtility
    {
        private const string AES_CIPHER_ALGORITHM_GCM = "AES/GCM";
        private const string AES_CIPHER_PADDING_NOPADDING = "NoPadding";

        /// <summary>
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="keyBytes">AES 密钥字节数组。</param>
        /// <param name="ivBytes">加密使用的初始化向量字节数组。</param>
        /// <param name="aadBytes">加密使用的附加数据包字节数组。</param>
        /// <param name="cipherBytes">待解密数据字节数组。</param>
        /// <returns>解密后的数据字节数组。</returns>
        public static byte[] DecryptWithGCM(byte[] keyBytes, byte[] ivBytes, byte[] aadBytes, byte[] cipherBytes)
        {
            if (keyBytes == null) throw new ArgumentNullException(nameof(keyBytes));
            if (ivBytes == null) throw new ArgumentNullException(nameof(ivBytes));
            if (aadBytes == null) throw new ArgumentNullException(nameof(aadBytes));
            if (cipherBytes == null) throw new ArgumentNullException(nameof(cipherBytes));

            const int TAG_LENGTH_BIT = 128;
            IBufferedCipher cipher = CipherUtilities.GetCipher(string.Format("{0}/{1}", AES_CIPHER_ALGORITHM_GCM, AES_CIPHER_PADDING_NOPADDING));
            ICipherParameters aeadParams = new AeadParameters(
                new KeyParameter(keyBytes),
                TAG_LENGTH_BIT,
                ivBytes,
                aadBytes
            );
            cipher.Init(false, aeadParams);
            byte[] plainBytes = new byte[cipher.GetOutputSize(cipherBytes.Length)];
            int len = cipher.ProcessBytes(cipherBytes, 0, cipherBytes.Length, plainBytes, 0);
            cipher.DoFinal(plainBytes, len);
            return plainBytes;
        }

        /// <summary>
        /// 基于 GCM 模式解密数据。
        /// </summary>
        /// <param name="key">AES 密钥。</param>
        /// <param name="iv">加密使用的初始化向量。</param>
        /// <param name="aad">加密使用的附加数据包。</param>
        /// <param name="cipherText">经 Base64 编码后的待解密数据。</param>
        /// <returns>解密后的文本数据。</returns>
        public static string DecryptWithGCM(string key, string iv, string? aad, string cipherText)
        {
            if (key == null) throw new ArgumentNullException(nameof(key));
            if (iv == null) throw new ArgumentNullException(nameof(iv));
            if (cipherText == null) throw new ArgumentNullException(nameof(cipherText));

            byte[] plainBytes = DecryptWithGCM(
                keyBytes: Encoding.UTF8.GetBytes(key),
                ivBytes: Encoding.UTF8.GetBytes(iv),
                aadBytes: Encoding.UTF8.GetBytes(aad ?? string.Empty),
                cipherBytes: Convert.FromBase64String(cipherText)
            );
            return Encoding.UTF8.GetString(plainBytes);
        }
    }
}
