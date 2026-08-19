namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentorder/create 接口的响应。</para>
    /// </summary>
    public class ChannelsECOrderPresentOrderCreateResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置礼物订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
        public string PresentOrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置外部 App 跳转业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置外部 App 跳转参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query")]
        [System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? QueryString { get; set; }
    }
}
