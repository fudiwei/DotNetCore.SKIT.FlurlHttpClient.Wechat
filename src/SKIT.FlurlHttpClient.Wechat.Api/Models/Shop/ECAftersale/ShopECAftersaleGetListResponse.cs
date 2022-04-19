namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/get_list 接口的响应。</para>
    /// </summary>
    public class ShopECAftersaleGetListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置售后单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sales_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sales_orders")]
        public string[] AftersaleOrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
