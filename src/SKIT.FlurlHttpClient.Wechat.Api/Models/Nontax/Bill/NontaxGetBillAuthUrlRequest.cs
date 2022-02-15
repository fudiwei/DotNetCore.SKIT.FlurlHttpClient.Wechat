using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/getbillauthurl 接口的请求。</para>
    /// </summary>
    public class NontaxGetBillAuthUrlRequest : WechatApiRequest, IMapResponse<NontaxGetBillAuthUrlRequest, NontaxGetBillAuthUrlResponse>
    {
        /// <summary>
        /// 获取或设置订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置财政局 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("s_pappid")]
        [System.Text.Json.Serialization.JsonPropertyName("s_pappid")]
        public string SpAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("money")]
        [System.Text.Json.Serialization.JsonPropertyName("money")]
        public int Fee { get; set; }

        /// <summary>
        /// 获取或设置时间戳。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp")]
        [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// 获取或设置开票来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("source")]
        [System.Text.Json.Serialization.JsonPropertyName("source")]
        public string Source { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权成功后跳转页面 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_url")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// 获取或设置微信票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("ticket")]
        public string Ticket { get; set; } = string.Empty;
    }
}
