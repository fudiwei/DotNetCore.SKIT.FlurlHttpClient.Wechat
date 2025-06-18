using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_fields 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetFieldsRequest : WechatWorkRequest
    {
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
