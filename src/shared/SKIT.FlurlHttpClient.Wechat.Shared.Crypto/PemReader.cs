namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    /// <summary>
    /// 
    /// </summary>
    static class PemReader
    {
        /// <summary>
        /// 格式化 PEM 编码字符串，去除头尾标识行和空白字符。
        /// </summary>
        /// <param name="encodingPEM">PEM 编码字符串。</param>
        /// <returns></returns>
        public static string Sanitize(string encodingPEM)
        {
            if (encodingPEM is null) throw new ArgumentNullException(nameof(encodingPEM));

            string sanitizedPEM = encodingPEM;
            sanitizedPEM = Regex.Replace(sanitizedPEM, @"-----BEGIN [^-]+-----", string.Empty);
            sanitizedPEM = Regex.Replace(sanitizedPEM, @"-----END [^-]+-----", string.Empty);
            sanitizedPEM = Regex.Replace(sanitizedPEM, @"\s+", string.Empty);
            return sanitizedPEM;
        }

        /// <summary>
        /// 将 PEM 编码字符串转为 DER 字节数组。
        /// </summary>
        /// <param name="encodingPEM">PEM 编码字符串。</param>
        /// <param name="sanitized">PEM 是否已格式化。</param>
        /// <returns></returns>
        public static byte[] ToBytes(string encodingPEM, bool sanitized = false)
        {
            if (encodingPEM is null) throw new ArgumentNullException(nameof(encodingPEM));

            string sanitizedPEM = sanitized ? encodingPEM : Sanitize(encodingPEM);
            return Convert.FromBase64String(sanitizedPEM);
        }
    }
}
