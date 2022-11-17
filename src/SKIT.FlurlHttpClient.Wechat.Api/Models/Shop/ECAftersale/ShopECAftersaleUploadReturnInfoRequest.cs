namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/uploadreturninfo 接口的请求。</para>
    /// </summary>
    public class ShopECAftersaleUploadReturnInfoRequest : WechatApiRequest, IInferable<ShopECAftersaleUploadReturnInfoRequest, ShopECAftersaleUploadReturnInfoResponse>
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

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_id")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
        public string DeliveryId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递公司名字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_name")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_name")]
        public string DeliveryName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置快递单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;
    }
}
