using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderGetRequest : WechatApiRequest, IInferable<ChannelsECOrderGetRequest, ChannelsECOrderGetResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否对订单进行脱敏。
        /// </summary>
        [Obsolete("相关接口或字段于 2025-07-15 下线。")]
        [Newtonsoft.Json.JsonProperty("encode_sensitive_info")]
        [System.Text.Json.Serialization.JsonPropertyName("encode_sensitive_info")]
        public bool? RequireEncodeSensitiveInfo { get; set; }
    }
}
