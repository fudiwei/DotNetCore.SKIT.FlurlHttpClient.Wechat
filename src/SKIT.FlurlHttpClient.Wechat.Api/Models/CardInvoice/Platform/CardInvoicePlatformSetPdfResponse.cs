using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/platform/setpdf 接口的响应。</para>
    /// </summary>
    public class CardInvoicePlatformSetPdfResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置发票文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("s_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("s_media_id")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedStringConverter))]
        public string SpMediaId { get; set; } = default!;
    }
}
