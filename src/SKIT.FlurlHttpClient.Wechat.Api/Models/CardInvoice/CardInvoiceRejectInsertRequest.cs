using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/rejectinsert 接口的请求。</para>
    /// </summary>
    public class CardInvoiceRejectInsertRequest : WechatApiRequest, IMapResponse<CardInvoiceRejectInsertRequest, CardInvoiceRejectInsertResponse>
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置开票平台或财政局 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("s_pappid")]
        [System.Text.Json.Serialization.JsonPropertyName("s_pappid")]
        public string SpAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置跳转页面 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url")]
        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? RedirectUrl { get; set; }
    }
}
