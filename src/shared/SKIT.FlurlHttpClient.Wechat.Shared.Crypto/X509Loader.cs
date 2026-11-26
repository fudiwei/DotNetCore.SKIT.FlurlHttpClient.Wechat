using System.Security.Cryptography.X509Certificates;

namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto
{
    /// <summary>
    /// 
    /// </summary>
    static class X509Loader
    {
        /// <summary>
        /// 加载 PEM 编码字符串的 X.509 证书。
        /// </summary>
        /// <param name="encodingPEM">证书的 PEM 编码字符串。</param>
        /// <returns></returns>
        public static X509Certificate2 Load(string encodingPEM)
        {
            if (encodingPEM is null) throw new ArgumentNullException(nameof(encodingPEM));

            return Load(PemReader.ToBytes(encodingPEM, false));
        }

        /// <summary>
        /// 加载 PEM 编码字符串的 X.509 证书。
        /// </summary>
        /// <param name="der">证书的 DER 字节数组。</param>
        /// <returns></returns>
        public static X509Certificate2 Load(byte[] der)
        {
            if (der is null) throw new ArgumentNullException(nameof(der));

#if NET9_0_OR_GREATER
            return X509CertificateLoader.LoadCertificate(der);
#else
            return new X509Certificate2(der);
#endif
        }

        /// <summary>
        /// 加载 PEM 编码字符串的 X.509 证书。
        /// </summary>
        /// <param name="der">证书的 DER 字节数组。</param>
        /// <returns></returns>
        public static X509Certificate2 Load(ReadOnlySpan<byte> der)
        {
            return Load(der.ToArray());
        }
    }
}
