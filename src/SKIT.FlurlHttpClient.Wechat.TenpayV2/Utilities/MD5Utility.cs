using System;
using System.Security.Cryptography;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// MD5 算法工具类。
    /// </summary>
    public static class MD5Utility
    {
        /// <summary>
        /// 计算 MD5 哈希值。
        /// </summary>
        /// <param name="bytes">要计算哈希值的信息字节数组。</param>
        /// <returns>哈希值字节数组。</returns>
        public static byte[] Hash(byte[] bytes)
        {
            if (bytes is null) throw new ArgumentNullException(nameof(bytes));

#if NET5_0_OR_GREATER
            return MD5.HashData(bytes);
#else
            using MD5 md5 = MD5.Create();
            return md5.ComputeHash(bytes);
#endif
        }

        /// <summary>
        /// 计算 MD5 哈希值。
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
