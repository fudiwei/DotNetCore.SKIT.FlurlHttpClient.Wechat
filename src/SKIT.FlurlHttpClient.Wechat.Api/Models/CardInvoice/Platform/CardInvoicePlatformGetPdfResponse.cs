using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/platform/getpdf 接口的响应。</para>
    /// </summary>
    public class CardInvoicePlatformGetPdfResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置发票文件 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pdf_url")]
        [System.Text.Json.Serialization.JsonPropertyName("pdf_url")]
        public string PdfUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置发票文件 URL 有效时间（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pdf_url_expire_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pdf_url_expire_time")]
        public int ExpiresIn { get; set; }
    }
}
