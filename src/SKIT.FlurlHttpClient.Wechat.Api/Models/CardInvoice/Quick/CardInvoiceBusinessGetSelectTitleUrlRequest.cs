using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/biz/getselecttitleurl 接口的请求。</para>
    /// </summary>
    public class CardInvoiceBusinessGetSelectTitleUrlRequest : WechatApiRequest, IMapResponse<CardInvoiceBusinessGetSelectTitleUrlRequest, CardInvoiceBusinessGetSelectTitleUrlResponse>
    {
        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置商户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_name")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_name")]
        public string? BusinessName { get; set; }
    }
}
