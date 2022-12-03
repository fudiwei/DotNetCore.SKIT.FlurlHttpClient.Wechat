namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_doc_base_info 接口的响应。</para>
    /// </summary>
    public class CgibinWedocGetDocumentBaseInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Document
            {
                /// <summary>
                /// 获取或设置文档 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("docid")]
                [System.Text.Json.Serialization.JsonPropertyName("docid")]
                public string DocumentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置文档类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("doc_type")]
                public int DocumentType { get; set; }

                /// <summary>
                /// 获取或设置文档名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("doc_name")]
                [System.Text.Json.Serialization.JsonPropertyName("doc_name")]
                public string DocumentName { get; set; } = default!;

                /// <summary>
                /// 获取或设置文档创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置文档最后修改的时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_time")]
                [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                public long ModifyTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文档信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("doc_base_info")]
        [System.Text.Json.Serialization.JsonPropertyName("doc_base_info")]
        public Types.Document Document { get; set; } = default!;
    }
}
