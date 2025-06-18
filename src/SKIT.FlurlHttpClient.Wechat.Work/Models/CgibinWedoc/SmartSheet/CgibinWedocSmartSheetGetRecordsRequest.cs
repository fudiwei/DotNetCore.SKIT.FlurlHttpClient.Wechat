using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_records 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetRecordsRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class SortField
            {
                /// <summary>
                /// 获取或设置字段标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("field_title")]
                [System.Text.Json.Serialization.JsonPropertyName("field_title")]
                public string FieldTitle { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否降序。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc")]
                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                public bool IsDescend { get; set; }
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
        /// 获取或设置视图 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_id")]
        [System.Text.Json.Serialization.JsonPropertyName("view_id")]
        public string? ViewId { get; set; }

        /// <summary>
        /// 获取或设置记录 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("record_ids")]
        public IList<string>? RecordIdList { get; set; }

        /// <summary>
        /// 获取或设置字段 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("field_ids")]
        public IList<string>? FieldIdList { get; set; }

        /// <summary>
        /// 获取或设置字段标题列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("field_titles")]
        [System.Text.Json.Serialization.JsonPropertyName("field_titles")]
        public IList<string>? FieldTitleList { get; set; }

        /// <summary>
        /// 获取或设置单元格键类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("key_type")]
        [System.Text.Json.Serialization.JsonPropertyName("key_type")]
        public string? KeyType { get; set; }

        /// <summary>
        /// 获取或设置排序字段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sort")]
        [System.Text.Json.Serialization.JsonPropertyName("sort")]
        public IList<Types.SortField>? SortFieldList { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
