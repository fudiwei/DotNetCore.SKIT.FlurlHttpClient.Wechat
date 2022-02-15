using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/delivery/recieve 接口的请求。</para>
    /// </summary>
    public class ShopDeliveryReceiveRequest : WechatApiRequest, IMapResponse<ShopDeliveryReceiveRequest, ShopDeliveryReceiveResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。与字段 <see cref="OutOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long? OrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义订单号。与字段 <see cref="OrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
        public string? OutOrderId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
