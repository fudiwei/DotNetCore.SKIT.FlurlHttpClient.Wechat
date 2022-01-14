namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/insertbill 接口的响应。</para>
    /// </summary>
    public class NontaxInsertBillResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置非税票据卡券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string CardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置获得非税票据的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;
    }
}
