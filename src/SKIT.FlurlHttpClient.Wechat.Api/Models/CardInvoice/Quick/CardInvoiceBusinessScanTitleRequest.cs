using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/scantitle 接口的请求。</para>
    /// </summary>
    public class CardInvoiceBusinessScanTitleRequest : WechatApiRequest, IMapResponse<CardInvoiceBusinessScanTitleRequest, CardInvoiceBusinessScanTitleResponse>
    {
        /// <summary>
        /// 获取或设置扫码后获得的文本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scan_text")]
        [System.Text.Json.Serialization.JsonPropertyName("scan_text")]
        public string ScanText { get; set; } = string.Empty;
    }
}
