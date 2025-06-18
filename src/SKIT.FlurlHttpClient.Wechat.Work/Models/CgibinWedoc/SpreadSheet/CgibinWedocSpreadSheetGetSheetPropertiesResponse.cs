namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/spreadsheet/get_sheet_properties 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSpreadSheetGetSheetPropertiesResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class SheetProperty
            {
                /// <summary>
                /// 获取或设置工作表 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sheet_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
                public string SheetId { get; set; } = default!;

                /// <summary>
                /// 获取或设置工作表名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置总行数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("row_count")]
                [System.Text.Json.Serialization.JsonPropertyName("row_count")]
                public int RowCount { get; set; }

                /// <summary>
                /// 获取或设置总列数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("column_count")]
                [System.Text.Json.Serialization.JsonPropertyName("column_count")]
                public int ColumnCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置工作表属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.SheetProperty[] SheetPropertyList { get; set; } = default!;
    }
}
