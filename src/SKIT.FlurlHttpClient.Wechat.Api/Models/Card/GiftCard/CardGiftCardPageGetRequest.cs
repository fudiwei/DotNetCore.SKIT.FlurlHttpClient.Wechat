namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/page/get 接口的请求。</para>
    /// </summary>
    public class CardGiftCardPageGetRequest : WechatApiRequest, IMapResponse<CardGiftCardPageGetRequest, CardGiftCardPageGetResponse>
    {
        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_id")]
        [System.Text.Json.Serialization.JsonPropertyName("page_id")]
        public string PageId { get; set; } = string.Empty;
    }
}
