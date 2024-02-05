using System;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// SHA-1 算法工具类。
    /// </summary>
    public static class SHA1Utility
    {
        /// <summary>
        /// 计算 SHA-1 哈希值。
        /// </summary>
        /// <param name="messageBytes">要计算哈希值的信息字节数组。</param>
        /// <returns>哈希值字节数组。</returns>
        public static byte[] Hash(byte[] messageBytes)
        {
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

#if NET5_0_OR_GREATER
            return SHA1.HashData(messageBytes);
#else
            using SHA1 sha1 = SHA1.Create();
            return sha1.ComputeHash(messageBytes);
#endif
        }

        /// <summary>
        /// 计算 SHA-1 哈希值。
        /// </summary>
        /// <param name="messageData">要计算哈希值的信息。</param>
        /// <returns>经过十六进制编码的哈希值。</returns>
        public static EncodedString Hash(string messageData)
        {
            if (messageData is null) throw new ArgumentNullException(nameof(messageData));

            byte[] messageBytes = EncodedString.FromLiteralString(messageData);
            byte[] hashBytes = Hash(messageBytes);
            return EncodedString.ToHexString(hashBytes);
        }
    }
}
