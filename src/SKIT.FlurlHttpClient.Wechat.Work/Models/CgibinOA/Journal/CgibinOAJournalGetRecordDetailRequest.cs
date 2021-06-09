using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/get_record_detail 接口的请求。</para>
    /// </summary>
    public class CgibinOAJournalGetRecordDetailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置汇报 UUID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("journaluuid")]
        [System.Text.Json.Serialization.JsonPropertyName("journaluuid")]
        public string JournalId { get; set; } = string.Empty;
    }
}
