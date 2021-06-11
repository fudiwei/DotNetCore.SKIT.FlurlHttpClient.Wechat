using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/get_latest_auditstatus 接口的响应。</para>
    /// </summary>
    public class WxaGetLatestAuditStatusResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置审核单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auditid")]
        [System.Text.Json.Serialization.JsonPropertyName("auditid")]
        public int AuditId { get; set; }

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置审核失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置截图 MediaId 列表，使用竖线分隔。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ScreenShot")]
        [System.Text.Json.Serialization.JsonPropertyName("ScreenShot")]
        public string? ScreenshotMediaIds { get; set; }
    }
}
