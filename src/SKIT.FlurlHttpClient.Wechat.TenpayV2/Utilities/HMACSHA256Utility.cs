using System;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    /// <summary>
    /// HMAC-SHA-256 算法工具类。
    /// </summary>
    public static class HMACSHA256Utility
    {
        /// <summary>
        /// 获取信息摘要。
        /// </summary>
        /// <param name="secretBytes">密钥字节数组。</param>
        /// <param name="bytes">信息字节数组。</param>
        /// <returns>信息摘要。</returns>
        public static string Hash(byte[] secretBytes, byte[] bytes)
        {
            if (secretBytes == null) throw new ArgumentNullException(nameof(secretBytes));
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            using HMAC hmac = new HMACSHA256(secretBytes);
            byte[] hashBytes = hmac.ComputeHash(bytes);
            return BitConverter.ToString(hashBytes).Replace("-", "");
        }

        /// <summary>
        /// 获取信息摘要。
        /// </summary>
        /// <param name="secret">密钥。</param>
        /// <param name="message">文本信息。</param>
        /// <returns>信息摘要。</returns>
        public static string Hash(string secret, string message)
        {
            if (secret == null) throw new ArgumentNullException(nameof(secret));
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] secretBytes = Encoding.UTF8.GetBytes(secret);
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            return Hash(secretBytes, bytes);
        }
    }
}
