namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Settings
{
    /// <summary>
    /// 微信支付平台认证方案。
    /// </summary>
    public enum PlatformAuthScheme
    {
        /// <summary>
        /// 使用平台证书进行认证。
        /// </summary>
        Certificate = 0,

        /// <summary>
        /// 使用平台公钥进行认证。
        /// </summary>
        PublicKey = 1
    }
}
