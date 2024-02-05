using System;
using Org.BouncyCastle.Crypto.Digests;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    using SKIT.FlurlHttpClient.Primitives;

    /// <summary>
    /// SM3 算法工具类。
    /// </summary>
    public static class SM3Utility
    {
        /// <summary>
        /// 计算 SM3 哈希值。
        /// </summary>
        /// <param name="bytes">要计算哈希值的信息字节数组。</param>
        /// <returns>哈希值字节数组。</returns>
        public static byte[] Hash(byte[] bytes)
        {
            if (bytes is null) throw new ArgumentNullException(nameof(bytes));

            SM3Digest sm3 = new SM3Digest();
            sm3.BlockUpdate(bytes, 0, bytes.Length);
            byte[] hashBytes = new byte[sm3.GetDigestSize()];
            sm3.DoFinal(hashBytes, 0);
            return hashBytes;
        }

        /// <summary>
        /// 计算 SM3 哈希值。
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
