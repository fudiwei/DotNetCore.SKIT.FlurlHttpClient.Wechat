﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /scan/product/v2/status 接口的请求。</para>
    /// </summary>
    public class ScanProductStatusV2Request : WechatApiRequest, IInferable<ScanProductStatusV2Request, ScanProductStatusV2Response>
    {
        /// <summary>
        /// 获取或设置用于获取导入结果的票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("status_ticket")]
        public string Ticket { get; set; } = string.Empty;
    }
}
