using System;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Utilities
{
    /// <summary>
    /// SM3 算法工具类。
    /// </summary>
    public static class SM3Utility
    {
        /// <summary>
        /// 获取 SM3 哈希值。
        /// </summary>
        /// <param name="bytes">信息字节数组。</param>
        /// <returns>哈希字节数组。</returns>
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
        /// 获取 SM3 哈希值。
        /// </summary>
        /// <param name="message">文本信息。</param>
        /// <returns>哈希值。</returns>
        public static string Hash(string message)
        {
            if (message is null) throw new ArgumentNullException(nameof(message));

            byte[] msgBytes = Encoding.UTF8.GetBytes(message);
            byte[] hashBytes = Hash(msgBytes);
            return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
        }
    }
}
