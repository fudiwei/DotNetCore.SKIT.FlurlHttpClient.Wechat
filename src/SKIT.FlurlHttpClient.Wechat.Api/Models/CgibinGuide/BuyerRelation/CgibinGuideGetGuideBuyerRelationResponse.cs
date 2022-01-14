namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidebuyerrelation 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideBuyerRelationResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置客户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string BuyerOpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置客户微信昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buyer_nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("buyer_nickname")]
        public string BuyerNickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置绑定时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        public long CreateTimestamp { get; set; }
    }
}
