using System;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Utilities
{
    /// <summary>
    /// SHA-256 算法工具类。
    /// </summary>
    public static class Sha256Util
    {
        /// <summary>
        /// 获取信息摘要。
        /// </summary>
        /// <param name="bytes">信息字节数组。</param>
        /// <returns>信息摘要。</returns>
        public static string Hash(byte[] bytes)
        {
            if (bytes == null) throw new ArgumentNullException(nameof(bytes));

            IDigest digest = new Sha256Digest();
            byte[] hashBytes = new byte[digest.GetDigestSize()];
            digest.BlockUpdate(bytes, 0, bytes.Length);
            digest.DoFinal(hashBytes, 0);
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
