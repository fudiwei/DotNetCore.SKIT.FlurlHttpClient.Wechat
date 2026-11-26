namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto.RSA
{
    /// <summary>
    /// 
    /// </summary>
    static class RSAKeySniffer
    {
        const int MAX = 32;

        /// <summary>
        /// 启发式（非严格）检测 RSA 私钥封装格式。
        /// </summary>
        /// <param name="pem">RSA 私钥的 PEM 编码字符串（不含头尾标识行）。</param>
        /// <returns></returns>
        public static RSAPrivateKeyFormat DetectPrivateKeyFormat(ReadOnlySpan<char> pem)
        {
            Span<char> cleaned = stackalloc char[MAX];
            int len = 0;
            foreach (char c in pem)
            {
                if (char.IsWhiteSpace(c)) continue;
                if (len < cleaned.Length) cleaned[len++] = c;
                else break;
            }
            if (len < 4) return RSAPrivateKeyFormat.Unknown;

            int paddedLen = (len + 3) & ~3;
            Span<char> padded = stackalloc char[paddedLen];
            cleaned.Slice(0, len).CopyTo(padded);
            for (int i = len; i < paddedLen; i++)
            {
                padded[i] = '=';
            }

            byte[] der;
            try
            {
                char[] arr = padded.Slice(0, paddedLen).ToArray();
                der = Convert.FromBase64CharArray(arr, 0, paddedLen);
            }
            catch
            {
                return RSAPrivateKeyFormat.Unknown;
            }

            return DetectPrivateKeyFormat(der);
        }

        /// <summary>
        /// 启发式（非严格）检测 RSA 私钥封装格式。
        /// </summary>
        /// <param name="der">RSA 私钥的 DER 字节数组。</param>
        /// <returns></returns>
        public static RSAPrivateKeyFormat DetectPrivateKeyFormat(ReadOnlySpan<byte> der)
        {
            if (der.Length < 4 || der[0] != 0x30)
                return RSAPrivateKeyFormat.Unknown;

            for (int i = 1; i < der.Length - 3; i++)
            {
                if (i >= MAX) break;
                if (der[i] == 0x02 && der[i + 1] == 0x01 && der[i + 2] == 0x00)
                {
                    byte next = der[i + 3];
                    if (next == 0x30) return RSAPrivateKeyFormat.PKCS8;
                    if (next == 0x02) return RSAPrivateKeyFormat.PKCS1;
                    if (next == 0x03 || next == 0x04) return RSAPrivateKeyFormat.PKCS1;
                    break;
                }
            }

            int pos = 1;
            if (pos >= der.Length) return RSAPrivateKeyFormat.Unknown;
            byte lenByte = der[pos++];
            if ((lenByte & 0x80) != 0)
            {
                int lenOfLen = lenByte & 0x7F;
                pos += lenOfLen;
            }
            if (pos >= der.Length) return RSAPrivateKeyFormat.Unknown;

            return der[pos] switch
            {
                0x30 => RSAPrivateKeyFormat.PKCS8,
                0x02 => RSAPrivateKeyFormat.PKCS1,
                _ => RSAPrivateKeyFormat.Unknown
            };
        }

        /// <summary>
        /// 启发式（非严格）检测 RSA 公钥封装格式。
        /// </summary>
        /// <param name="pem">RSA 公钥的 PEM 编码字符串（不含头尾标识行）。</param>
        /// <returns></returns>
        public static RSAPublicKeyFormat DetectPublicKeyFormat(ReadOnlySpan<char> pem)
        {
            Span<char> cleaned = stackalloc char[MAX];
            int len = 0;
            foreach (char c in pem)
            {
                if (char.IsWhiteSpace(c)) continue;
                if (len < cleaned.Length) cleaned[len++] = c;
                else break;
            }
            if (len < 4) return RSAPublicKeyFormat.Unknown;

            int paddedLen = (len + 3) & ~3;
            Span<char> padded = stackalloc char[paddedLen];
            cleaned.Slice(0, len).CopyTo(padded);
            for (int i = len; i < paddedLen; i++)
            {
                padded[i] = '=';
            }

            byte[] der;
            try
            {
                char[] arr = padded.Slice(0, paddedLen).ToArray();
                der = Convert.FromBase64CharArray(arr, 0, paddedLen);
            }
            catch
            {
                return RSAPublicKeyFormat.Unknown;
            }

            return DetectPublicKeyFormat(der);
        }

        /// <summary>
        /// 启发式（非严格）检测 RSA 公钥封装格式。
        /// </summary>
        /// <param name="der">RSA 公钥的 DER 字节数组。</param>
        /// <returns></returns>
        public static RSAPublicKeyFormat DetectPublicKeyFormat(ReadOnlySpan<byte> der)
        {
            if (der.Length < 3 || der[0] != 0x30)
                return RSAPublicKeyFormat.Unknown;

            int pos = 1;
            byte lenByte = der[pos++];
            if ((lenByte & 0x80) != 0)
                pos += lenByte & 0x7F;
            if (pos >= der.Length) return RSAPublicKeyFormat.Unknown;

            return der[pos] switch
            {
                0x30 => RSAPublicKeyFormat.SPKI,
                0x02 => RSAPublicKeyFormat.PKCS1,
                _ => RSAPublicKeyFormat.Unknown
            };
        }
    }
}
