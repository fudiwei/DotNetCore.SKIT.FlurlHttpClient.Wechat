using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/update_records 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetUpdateRecordsRequest : WechatWorkRequest
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
                public string RecordId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置单元格值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("values")]
                [System.Text.Json.Serialization.JsonPropertyName("values")]
                public IDictionary<string, object> Values { get; set; } = new Dictionary<string, object>();
            }
        }

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子表 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sheet_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
        public string SheetId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置单元格键类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key_type")]
        [System.Text.Json.Serialization.JsonPropertyName("key_type")]
        public string? KeyType { get; set; }

        /// <summary>
        /// 获取或设置记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("records")]
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public IList<Types.Record> RecordList { get; set; } = new List<Types.Record>();
    }
}
