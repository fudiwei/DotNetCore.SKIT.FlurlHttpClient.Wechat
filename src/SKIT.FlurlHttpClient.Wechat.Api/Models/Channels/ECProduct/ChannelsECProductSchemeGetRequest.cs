namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/scheme/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductSchemeGetRequest : WechatApiRequest, IInferable<ChannelsECProductSchemeGetRequest, ChannelsECProductSchemeGetResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置来源 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("from_appid")]
        public string FromAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置过期时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire")]
        [System.Text.Json.Serialization.JsonPropertyName("expire")]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_info")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_info")]
        public string? ExtraInfo { get; set; }
    }
}
