namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_view 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddViewRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class GanttViewProperty
            {
                /// <summary>
                /// 获取或设置时间条起点字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date_field_id")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date_field_id")]
                public string StartDateFieldId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置时间条终点字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date_field_id")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date_field_id")]
                public string EndDateFieldId { get; set; } = string.Empty;
            }

            public class CalendarViewProperty
            {
                /// <summary>
                /// 获取或设置时间条起点字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("start_date_field_id")]
                [System.Text.Json.Serialization.JsonPropertyName("start_date_field_id")]
                public string StartDateFieldId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置时间条终点字段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_date_field_id")]
                [System.Text.Json.Serialization.JsonPropertyName("end_date_field_id")]
                public string EndDateFieldId { get; set; } = string.Empty;
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
        /// 获取或设置视图名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_title")]
        [System.Text.Json.Serialization.JsonPropertyName("view_title")]
        public string ViewTitle { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视图类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_type")]
        [System.Text.Json.Serialization.JsonPropertyName("view_type")]
        public string ViewType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置甘特视图属性信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("property_gantt")]
        [System.Text.Json.Serialization.JsonPropertyName("property_gantt")]
        public Types.GanttViewProperty? ViewPropertyAsGantt { get; set; }

        /// <summary>
        /// 获取或设置日历视图属性信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("property_calendar")]
        [System.Text.Json.Serialization.JsonPropertyName("property_calendar")]
        public Types.CalendarViewProperty? ViewPropertyAsCalendar { get; set; }
    }
}
