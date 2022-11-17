using System;
using System.Security.Cryptography;
using System.Text;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Utilities
{
    /// <summary>
    /// HMAC 算法工具类。
    /// </summary>
    public static class HMACUtility
    {
        /// <summary>
        /// 获取 HMAC-SHA-256 消息认证码。
        /// </summary>
        /// <param name="secretBytes">密钥字节数组。</param>
        /// <param name="msgBytes">信息字节数组。</param>
        /// <returns>消息认证码字节数组。</returns>
        public static byte[] HashWithSHA256(byte[] secretBytes, byte[] msgBytes)
        {
            if (secretBytes == null) throw new ArgumentNullException(nameof(secretBytes));
            if (msgBytes == null) throw new ArgumentNullException(nameof(msgBytes));

            using HMAC hmac = new HMACSHA256(secretBytes);
            return hmac.ComputeHash(msgBytes);
        }

        /// <summary>
        /// 获取 HMAC-SHA-256 消息认证码。
        /// </summary>
        /// <param name="secret">密钥。</param>
        /// <param name="message">文本信息。</param>
        /// <returns>消息认证码。</returns>
        public static string HashWithSHA256(string secret, string message)
        {
            if (secret == null) throw new ArgumentNullException(nameof(secret));
            if (message == null) throw new ArgumentNullException(nameof(message));

            byte[] secretBytes = Encoding.UTF8.GetBytes(secret);
            byte[] msgBytes = Encoding.UTF8.GetBytes(message);
            byte[] hashBytes = HashWithSHA256(secretBytes, msgBytes);
            return BitConverter.ToString(hashBytes).Replace("-", string.Empty);
        }
    }
}
