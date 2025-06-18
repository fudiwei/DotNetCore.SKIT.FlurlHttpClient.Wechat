namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/analyze_task_result 接口的响应。</para>
    /// </summary>
    public class CgibinChatDataAnalyzeTaskResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class BatchResult
            {
                public static class Types
                {
                    public class ServiceEncryptInfo : CgibinChatDataSyncMessageResponse.Types.Message.Types.ServiceEncryptInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置分析结果临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result_id")]
                [System.Text.Json.Serialization.JsonPropertyName("result_id")]
                public string ResultId { get; set; } = default!;

                /// <summary>
                /// 获取或设置加密信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_encrypt_info")]
                [System.Text.Json.Serialization.JsonPropertyName("service_encrypt_info")]
                public Types.ServiceEncryptInfo ServiceEncryptInfo { get; set; } = default!;
            }

            public class ItemResult
            {
                /// <summary>
                /// 获取或设置消息 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("msgid")]
                [System.Text.Json.Serialization.JsonPropertyName("msgid")]
                public string MessageId { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置情感分析结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sentiment_result")]
                [System.Text.Json.Serialization.JsonPropertyName("sentiment_result")]
                public int? SentimentResult { get; set; }

                /// <summary>
                /// 获取或设置反垃圾分析结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spam_result")]
                [System.Text.Json.Serialization.JsonPropertyName("spam_result")]
                public int? SpamResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置批量任务的分析结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("analyze_result")]
        [System.Text.Json.Serialization.JsonPropertyName("analyze_result")]
        public Types.BatchResult? BatchResult { get; set; }

        /// <summary>
        /// 获取或设置单条任务的分析结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("analyze_result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("analyze_result_list")]
        public Types.ItemResult[]? ItemResultList { get; set; }
    }
}
