using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/platform/getpdf 接口的请求。</para>
    /// </summary>
    public class CardInvoicePlatformGetPdfRequest : WechatApiRequest
    {
        /// <summary>
        /// <i>（使用默认值即可，无需修改）</i>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action")]
        [System.Text.Json.Serialization.JsonPropertyName("action")]
        public string Action { get; set; } = "get_url";

        /// <summary>
        /// 获取或设置发票文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("s_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("s_media_id")]
        public string SpMediaId { get; set; } = string.Empty;
    }
}
