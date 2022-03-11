using System;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    /// <summary>
    /// MD5 算法工具类。
    /// </summary>
    public static class MD5Utility
    {
        /// <summary>
        /// 获取 MD5 信息摘要。
        /// </summary>
        /// <param name="bytes">信息字节数组。</param>
        /// <returns>信息摘要字节数组。</returns>
        public static byte[] Hash(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            using MD5 md5 = MD5.Create();
            return md5.ComputeHash(bytes);
        }

        /// <summary>
        /// 获取 MD5 信息摘要。
        /// </summary>
        /// <param name="message">文本信息。</param>
        /// <returns>信息摘要。</returns>
        public static string Hash(string message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] msgBytes = Encoding.UTF8.GetBytes(message);
            byte[] hashBytes = Hash(msgBytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }
    }
}
