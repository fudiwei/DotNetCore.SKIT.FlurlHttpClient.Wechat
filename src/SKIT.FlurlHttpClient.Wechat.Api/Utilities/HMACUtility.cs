using System;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.Api.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// HMAC 算法工具类。
    /// </summary>
    public static class HMACUtility
    {
        /// <summary>
        /// 计算 HMAC-SHA-256 哈希值。
        /// </summary>
        /// <param name="keyBytes">密钥字节数组。</param>
        /// <param name="msgBytes">要计算哈希值的信息字节数组。</param>
        /// <returns>哈希值字节数组。</returns>
        public static byte[] HashWithSHA256(byte[] keyBytes, byte[] msgBytes)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (msgBytes is null) throw new ArgumentNullException(nameof(msgBytes));

#if NET5_0_OR_GREATER
            return HMACSHA256.HashData(keyBytes, msgBytes);
#else
            using HMAC hmac = new HMACSHA256(keyBytes);
            return hmac.ComputeHash(msgBytes);
#endif
        }

        /// <summary>
        /// 计算 HMAC-SHA-256 哈希值。
        /// </summary>
        /// <param name="key">密钥。</param>
        /// <param name="message">要计算哈希值的信息。</param>
        /// <returns>经过十六进制编码的哈希值。</returns>
        public static EncodedString HashWithSHA256(string key, string message)
        {
            if (key is null) throw new ArgumentNullException(nameof(key));
            if (message is null) throw new ArgumentNullException(nameof(message));

            byte[] keyBytes = EncodedString.FromLiteralString(key);
            byte[] msgBytes = EncodedString.FromLiteralString(message);
            byte[] hashBytes = HashWithSHA256(keyBytes, msgBytes);
            return EncodedString.ToHexString(hashBytes);
        }
    }
}
