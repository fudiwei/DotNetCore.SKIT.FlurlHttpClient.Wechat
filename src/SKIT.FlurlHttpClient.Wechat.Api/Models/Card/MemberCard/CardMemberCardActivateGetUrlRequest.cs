namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/activate/geturl 接口的请求。</para>
    /// </summary>
    public class CardMemberCardActivateGetUrlRequest : WechatApiRequest, IMapResponse<CardMemberCardActivateGetUrlRequest, CardMemberCardActivateGetUrlResponse>
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户自定义字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("outer_str")]
        [System.Text.Json.Serialization.JsonPropertyName("outer_str")]
        public string? OuterString { get; set; }
    }
}
