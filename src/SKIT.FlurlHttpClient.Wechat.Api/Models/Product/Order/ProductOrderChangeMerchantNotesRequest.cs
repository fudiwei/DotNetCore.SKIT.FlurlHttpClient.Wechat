using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/order/change_merchant_notes 接口的请求。</para>
    /// </summary>
    public class ProductOrderChangeMerchantNotesRequest : WechatApiRequest, IMapResponse<ProductOrderChangeMerchantNotesRequest, ProductOrderChangeMerchantNotesResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 获取或设置商家备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_notes")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_notes")]
        public string MerchantNotes { get; set; } = string.Empty;
    }
}
