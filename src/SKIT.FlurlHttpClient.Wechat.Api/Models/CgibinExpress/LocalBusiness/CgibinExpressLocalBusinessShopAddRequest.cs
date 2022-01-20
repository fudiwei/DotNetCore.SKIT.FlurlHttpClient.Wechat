namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/shop/add 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessShopAddRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置配送公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;
    }
}
