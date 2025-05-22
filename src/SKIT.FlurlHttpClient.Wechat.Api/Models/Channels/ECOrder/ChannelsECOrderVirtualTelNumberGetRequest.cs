using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/virtualtelnumber/get 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-05-09 下线。")]
    public class ChannelsECOrderVirtualTelNumberGetRequest : WechatApiRequest, IInferable<ChannelsECOrderVirtualTelNumberGetRequest, ChannelsECOrderVirtualTelNumberGetResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;
    }
}
