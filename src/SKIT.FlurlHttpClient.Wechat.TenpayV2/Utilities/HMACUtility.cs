using System;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
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
        /// <param name="messageBytes">要计算哈希值的信息字节数组。</param>
        /// <returns>哈希值字节数组。</returns>
        public static byte[] HashWithSHA256(byte[] keyBytes, byte[] messageBytes)
        {
            if (keyBytes is null) throw new ArgumentNullException(nameof(keyBytes));
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

#if NET5_0_OR_GREATER
            return HMACSHA256.HashData(keyBytes, messageBytes);
#else
            using HMAC hmac = new HMACSHA256(keyBytes);
            return hmac.ComputeHash(messageBytes);
#endif
        }

        /// <summary>
        /// 计算 HMAC-SHA-256 哈希值。
        /// </summary>
        /// <param name="key">密钥。</param>
        /// <param name="messageData">要计算哈希值的信息。</param>
        /// <returns>经过十六进制编码的哈希值。</returns>
        public static EncodedString HashWithSHA256(string key, string messageData)
        {
            if (key is null) throw new ArgumentNullException(nameof(key));
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));

            byte[] keyBytes = EncodedString.FromLiteralString(key);
            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] hashBytes = HashWithSHA256(keyBytes, messageBytes);
            return EncodedString.ToHexString(hashBytes);
        }
    }
}
