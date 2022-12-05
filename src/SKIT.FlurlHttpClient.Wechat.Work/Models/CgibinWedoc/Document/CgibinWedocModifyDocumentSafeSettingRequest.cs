namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/mod_doc_safty_setting 接口的请求。</para>
    /// </summary>
    public class CgibinWedocModifyDocumentSafeSettingRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Watermark
            {
                /// <summary>
                /// 获取或设置水印文字。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("text")]
                [System.Text.Json.Serialization.JsonPropertyName("text")]
                public string? Text { get; set; }

                /// <summary>
                /// 获取或设置水印类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("margin_type")]
                [System.Text.Json.Serialization.JsonPropertyName("margin_type")]
                public int? MarginType { get; set; }

                /// <summary>
                /// 获取或设置是否开启水印文本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_text")]
                [System.Text.Json.Serialization.JsonPropertyName("show_text")]
                public bool? EnableShowText { get; set; }

                /// <summary>
                /// 获取或设置是否开启水印访问人名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("show_visitor_name")]
                [System.Text.Json.Serialization.JsonPropertyName("show_visitor_name")]
                public bool? EnableShowVisitorName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文档 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("docid")]
        [System.Text.Json.Serialization.JsonPropertyName("docid")]
        public string DocumentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否开启只读备份。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_readonly_copy")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_readonly_copy")]
        public bool? EnableReadonlyCopy { get; set; }

        /// <summary>
        /// 获取或设置是否开启只读评论。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable_readonly_comment")]
        [System.Text.Json.Serialization.JsonPropertyName("enable_readonly_comment")]
        public bool? EnableReadonlyComment { get; set; }

        /// <summary>
        /// 获取或设置水印信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("watermark")]
        [System.Text.Json.Serialization.JsonPropertyName("watermark")]
        public Types.Watermark? Watermark { get; set; }
    }
}
