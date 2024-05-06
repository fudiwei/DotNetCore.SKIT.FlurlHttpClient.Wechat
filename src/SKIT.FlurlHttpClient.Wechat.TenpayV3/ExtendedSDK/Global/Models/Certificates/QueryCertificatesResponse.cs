namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    using _ROOT_ = SKIT.FlurlHttpClient.Wechat.TenpayV3;

    /// <summary>
    /// <para>表示 [GET] /certificates 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class QueryCertificatesResponse : WechatTenpayGlobalResponse
    {
        public static class Types
        {
            public class Certificate : _ROOT_.Models.QueryCertificatesResponse.Types.Certificate
            {
            }
        }

        /// <summary>
        /// 获取或设置微信服务器证书列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Certificate[] CertificateList { get; set; } = default!;
    }
}
