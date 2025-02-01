namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/get_sheet 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetGetSheetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Sheet
            {
                /// <summary>
                /// 获取或设置子表 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sheet_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sheet_id")]
                public string SheetId { get; set; } = default!;

                /// <summary>
                /// 获取或设置子表名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置子表类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public string Type { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否可见。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_visible")]
                [System.Text.Json.Serialization.JsonPropertyName("is_visible")]
                public bool IsVisible { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子表列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sheet_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sheet_list")]
        public Types.Sheet[] SheetList { get; set; } = default!;
    }
}
