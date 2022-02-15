using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/invoice/platform/setpdf 接口的请求。</para>
    /// </summary>
    public class CardInvoicePlatformSetPdfRequest : WechatApiRequest, IMapResponse<CardInvoicePlatformSetPdfRequest, CardInvoicePlatformSetPdfResponse>
    {
        /// <summary>
        /// 获取或设置发票文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = new byte[0];
    }
}
