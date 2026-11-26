namespace SKIT.FlurlHttpClient.Wechat.Shared.Crypto.RSA
{
    /// <summary>
    /// 表示 RSA 私钥的封装格式类型。
    /// </summary>
    enum RSAPrivateKeyFormat
    {
        /// <summary>
        /// 未知格式。
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// PKCS#1 格式。形如：
        /// <code>
        /// -----BEGIN RSA PRIVATE KEY-----
        /// ...
        /// -----END RSA PRIVATE KEY-----
        /// </code>
        /// </summary>
        PKCS1,
        /// <summary>
        /// PKCS#8 格式。形如：
        /// <code>
        /// -----BEGIN PRIVATE KEY-----
        /// ...
        /// -----END PRIVATE KEY-----
        /// </code>
        /// </summary>
        PKCS8
    }

    /// <summary>
    /// 表示 RSA 公钥的封装格式类型。
    /// </summary>
    enum RSAPublicKeyFormat
    {
        /// <summary>
        /// 未知格式。
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// PKCS#1 格式。形如：
        /// <code>
        /// -----BEGIN RSA PUBLIC KEY-----
        /// ...
        /// -----END RSA PUBLIC KEY-----
        /// </code>
        /// </summary>
        PKCS1,
        /// <summary>
        /// SPKI 格式。形如：
        /// <code>
        /// -----BEGIN PUBLIC KEY-----
        /// ...
        /// -----END PUBLIC KEY-----
        /// </code>
        /// </summary>
        SPKI
    }
}
