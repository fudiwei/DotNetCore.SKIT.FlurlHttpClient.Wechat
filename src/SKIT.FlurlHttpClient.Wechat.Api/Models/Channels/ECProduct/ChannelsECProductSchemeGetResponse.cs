namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/scheme/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductSchemeGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置商品跳转 Scheme 链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openlink")]
        [System.Text.Json.Serialization.JsonPropertyName("openlink")]
        public string OpenLink { get; set; } = default!;
    }
}
