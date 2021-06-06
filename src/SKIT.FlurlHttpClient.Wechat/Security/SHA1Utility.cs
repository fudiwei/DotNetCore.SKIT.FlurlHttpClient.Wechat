using System;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.Security
{
    /// <summary>
    /// SHA-1 算法工具类。
    /// </summary>
    public static class SHA1Utility
    {
        /// <summary>
        /// 获取信息摘要。
        /// </summary>
        /// <param name="bytes">信息字节数组。</param>
        /// <returns>信息摘要。</returns>
        public static string Hash(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            using SHA1 sha = SHA1.Create();
            byte[] hashBytes = sha.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }

        /// <summary>
        /// 获取信息摘要。
        /// </summary>
        /// <param name="message">文本信息。</param>
        /// <returns>信息摘要。</returns>
        public static string Hash(string message)
        {
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] bytes = Encoding.UTF8.GetBytes(message);
            return Hash(bytes);
        }
    }
}
