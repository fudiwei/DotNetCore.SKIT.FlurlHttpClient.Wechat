namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/insert 接口的响应。</para>
    /// </summary>
    public class CardInvoiceInsertResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置发票卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置获得发票的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置获得发票的用户 UnionId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unionid")]
        [System.Text.Json.Serialization.JsonPropertyName("unionid")]
        public string? UnionId { get; set; }
    }
}
