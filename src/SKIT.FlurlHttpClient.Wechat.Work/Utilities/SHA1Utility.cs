using System;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.Work.Utilities
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
        /// <param name="bytes">要计算哈希值的信息字节数组。</param>
        /// <returns>哈希值字节数组。</returns>
        public static byte[] Hash(byte[] bytes)
        {
            if (bytes is null) throw new ArgumentNullException(nameof(bytes));

#if NET5_0_OR_GREATER
            return SHA1.HashData(bytes);
#else
            using SHA1 sha1 = SHA1.Create();
            return sha1.ComputeHash(bytes);
#endif
        }

        /// <summary>
        /// 计算 SHA-1 哈希值。
        /// </summary>
        /// <param name="message">要计算哈希值的信息。</param>
        /// <returns>经过十六进制编码的哈希值。</returns>
        public static EncodedString Hash(string message)
        {
            if (message is null) throw new ArgumentNullException(nameof(message));

            byte[] msgBytes = EncodedString.FromLiteralString(message);
            byte[] hashBytes = Hash(msgBytes);
            return EncodedString.ToHexString(hashBytes);
        }
    }
}
