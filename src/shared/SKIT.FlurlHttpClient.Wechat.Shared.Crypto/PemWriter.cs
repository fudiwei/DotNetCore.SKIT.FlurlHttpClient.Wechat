namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    /// <summary>
    /// 
    /// </summary>
    static class PemWriter
    {
        /// <summary>
        /// 将 DER 字节数组转为 PEM 编码字符串。
        /// </summary>
        /// <param name="tag">PEM 标签。</param>
        /// <param name="der">DER 字节数组。</param>
        /// <param name="breakLine">是否换行。</param>
        /// <returns></returns>
        public static string ToString(string tag, byte[] der, bool breakLine = false)
        {
            if (tag == null) throw new ArgumentNullException(nameof(tag));
            if (der == null) throw new ArgumentNullException(nameof(der));

            string header = $"-----BEGIN {tag}-----";
            string footer = $"-----END {tag}-----";
            string encodingData = Convert.ToBase64String(der);

            if (breakLine)
            {
                const int LINE_LENGTH = 64;
                const string LINE_BREAK = "\r\n";

                StringBuilder builder = new StringBuilder();

                builder.Append(header);
                builder.Append(LINE_BREAK);
                for (int i = 0; i < encodingData.Length; i += LINE_LENGTH)
                {
                    int length = Math.Min(LINE_LENGTH, encodingData.Length - i);
                    builder.Append(encodingData.Substring(i, length));
                    builder.Append(LINE_BREAK);
                }
                builder.Append(footer);
                builder.Append(LINE_BREAK);

                return builder.ToString();
            }

            return $"{header}{encodingData}{footer}";
        }
    }
}
