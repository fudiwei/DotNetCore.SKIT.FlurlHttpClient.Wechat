namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/add_sheet 接口的响应。</para>
    /// </summary>
    public class CgibinWedocSmartSheetAddSheetResponse : WechatWorkResponse
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
                /// 获取或设置子表下标。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("index")]
                [System.Text.Json.Serialization.JsonPropertyName("index")]
                public int Index { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("properties")]
        [System.Text.Json.Serialization.JsonPropertyName("properties")]
        public Types.Sheet Sheet { get; set; } = default!;
    }
}
