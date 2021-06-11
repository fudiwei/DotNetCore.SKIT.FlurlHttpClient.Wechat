using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /scan/product/v2/add 接口的响应。</para>
    /// </summary>
    public class ScanProductV2AddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置用于获取导入结果的票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("status_ticket")]
        public string Ticket { get; set; } = default!;
    }
}
