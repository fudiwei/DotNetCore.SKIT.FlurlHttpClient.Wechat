namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/reject 接口的请求。</para>
    /// </summary>
    public class ShopECAftersaleRejectRequest : WechatApiRequest, IInferable<ShopECAftersaleRejectRequest, ShopECAftersaleRejectResponse>
    {
        /// <summary>
        /// 获取或设置售后单号。与字段 <see cref="OutAftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public long? AftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义售后单号。与字段 <see cref="AftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
        public string? OutAftersaleOrderId { get; set; }
    }
}
