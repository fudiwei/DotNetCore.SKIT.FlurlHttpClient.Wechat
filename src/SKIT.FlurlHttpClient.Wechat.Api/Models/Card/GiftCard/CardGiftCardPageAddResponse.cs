namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/page/add 接口的响应。</para>
    /// </summary>
    public class CardGiftCardPageAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_id")]
        [System.Text.Json.Serialization.JsonPropertyName("page_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
        public string PageId { get; set; } = default!;
    }
}
