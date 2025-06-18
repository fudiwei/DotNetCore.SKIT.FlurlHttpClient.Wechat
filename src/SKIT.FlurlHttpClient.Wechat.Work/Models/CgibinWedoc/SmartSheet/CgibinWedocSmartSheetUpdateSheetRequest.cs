namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/smartsheet/update_sheet 接口的请求。</para>
    /// </summary>
    public class CgibinWedocSmartSheetUpdateSheetRequest : WechatWorkRequest
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
                public string SheetId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置子表名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子表信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("properties")]
        [System.Text.Json.Serialization.JsonPropertyName("properties")]
        public Types.Sheet Sheet { get; set; } = new Types.Sheet();
    }
}
