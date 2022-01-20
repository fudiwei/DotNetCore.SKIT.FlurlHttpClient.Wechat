namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/createbillcard 接口的响应。</para>
    /// </summary>
    public class NontaxCreateBillCardResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置非税票据卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;
    }
}
