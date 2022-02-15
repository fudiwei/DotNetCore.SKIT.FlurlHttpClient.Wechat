namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/shelf/add 接口的响应。</para>
    /// </summary>
    public class MerchantShelfAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置货架 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shelf_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shelf_id")]
        public int ShelfId { get; set; }
    }
}
