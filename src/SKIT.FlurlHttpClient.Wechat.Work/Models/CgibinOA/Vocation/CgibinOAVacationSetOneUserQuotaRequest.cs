using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/vacation/setoneuserquota 接口的请求。</para>
    /// </summary>
    public class CgibinOAVacationSetOneUserQuotaRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置假期类型标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vacation_id")]
        [System.Text.Json.Serialization.JsonPropertyName("vacation_id")]
        public int VacationId { get; set; }

        /// <summary>
        /// 获取或设置剩余时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("leftduration")]
        [System.Text.Json.Serialization.JsonPropertyName("leftduration")]
        public int LeftDuration { get; set; }

        /// <summary>
        /// 获取或设置假期时间刻度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_attr")]
        [System.Text.Json.Serialization.JsonPropertyName("time_attr")]
        public int TimeType { get; set; }

        /// <summary>
        /// 获取或设置备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remarks")]
        [System.Text.Json.Serialization.JsonPropertyName("remarks")]
        public string? Remark { get; set; }
    }
}
