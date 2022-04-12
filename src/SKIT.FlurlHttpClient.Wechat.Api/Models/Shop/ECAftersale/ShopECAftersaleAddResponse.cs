namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/add 接口的响应。</para>
    /// </summary>
    public class ShopECAftersaleAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置售后单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public long AftersaleOrderId { get; set; }
    }
}
