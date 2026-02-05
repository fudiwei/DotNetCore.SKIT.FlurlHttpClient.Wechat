using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentorder/get 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-12-08 下线。")]
    public class ChannelsECOrderPresentOrderGetRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentOrderGetRequest, ChannelsECOrderPresentOrderGetResponse>
    {
        /// <summary>
        /// 获取或设置礼物订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
        public string PresentOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
        public string? OpenId { get; set; }
    }
}
