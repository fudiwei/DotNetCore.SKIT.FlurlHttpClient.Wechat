using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/applyevent 接口的响应。</para>
    /// </summary>
    public class CgibinOAApplyEventResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置审批单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_no")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_no")]
        public string ApprovalNumber { get; set; } = default!;
    }
}
