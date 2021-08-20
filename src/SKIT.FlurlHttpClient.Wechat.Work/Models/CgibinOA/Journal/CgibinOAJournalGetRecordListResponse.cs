using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/oa/journal/get_record_list 接口的响应。</para>
    /// </summary>
    public class CgibinOAJournalGetRecordListResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置汇报 UUID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("journaluuid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("journaluuid_list")]
        public string[] JournalIdList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页是否结束。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endflag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("endflag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsEnding { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public int? NextCursor { get; set; }
    }
}
