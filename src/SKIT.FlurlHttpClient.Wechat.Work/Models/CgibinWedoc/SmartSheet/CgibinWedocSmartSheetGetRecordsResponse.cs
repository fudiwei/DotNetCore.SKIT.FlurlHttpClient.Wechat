using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_records 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetRecordsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Record
            {
                /// <summary>
                /// 获取或设置记录 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("record_id")]
                public string RecordId { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建者名字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator_name")]
                [System.Text.Json.Serialization.JsonPropertyName("creator_name")]
                public string CreatorName { get; set; } = default!;

                /// <summary>
                /// 获取或设置最后编辑者名字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updater_name")]
                [System.Text.Json.Serialization.JsonPropertyName("updater_name")]
                public string UpdaterName { get; set; } = default!;

                /// <summary>
                /// 获取或设置单元格值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("values")]
                [System.Text.Json.Serialization.JsonPropertyName("values")]
                public IDictionary<string, object> Values { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间毫秒级戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long CreateTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置更新时间毫秒级戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long UpdateTimeMilliseconds { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("records")]
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public Types.Record[] RecordList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total")]
        [System.Text.Json.Serialization.JsonPropertyName("total")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置下一页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next")]
        [System.Text.Json.Serialization.JsonPropertyName("next")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }
    }
}
