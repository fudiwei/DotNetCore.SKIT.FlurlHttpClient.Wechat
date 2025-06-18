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
        /// <param name="messageBytes">要计算哈希值的信息字节数组。</param>
        /// <returns>哈希值字节数组。</returns>
        public static byte[] Hash(byte[] messageBytes)
        {
            if (messageBytes is null) throw new ArgumentNullException(nameof(messageBytes));

            SM3Digest sm3 = new SM3Digest();
            sm3.BlockUpdate(messageBytes, 0, messageBytes.Length);
            byte[] hashBytes = new byte[sm3.GetDigestSize()];
            sm3.DoFinal(hashBytes, 0);
            return hashBytes;
        }

        /// <summary>
        /// 计算 SM3 哈希值。
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
