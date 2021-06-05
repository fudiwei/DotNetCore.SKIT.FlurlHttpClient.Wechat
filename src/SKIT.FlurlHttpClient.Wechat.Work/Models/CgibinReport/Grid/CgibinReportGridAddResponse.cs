using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/add 接口的响应。</para>
    /// </summary>
    public class CgibinReportGridAddResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置网格 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grid_id")]
        [System.Text.Json.Serialization.JsonPropertyName("grid_id")]
        public string GridId { get; set; } = default!;

        /// <summary>
        /// 获取或设置无效的 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_userids")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_userids")]
        public string[]? InvalidUserIdList { get; set; }
    }
}
