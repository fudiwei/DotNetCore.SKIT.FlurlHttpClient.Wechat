namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/gettask 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetTaskResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Task
            {
                /// <summary>
                /// 获取或设置拉取上传任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long Id { get; set; }

                /// <summary>
                /// 获取或设置任务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_type")]
                [System.Text.Json.Serialization.JsonPropertyName("task_type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置任务错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置任务错误原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置完成时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                public long? FinishTimestamp { get; set; }

                /// <summary>
                /// 获取或设置媒体文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? MediaId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置拉取上传任务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("task_info")]
        [System.Text.Json.Serialization.JsonPropertyName("task_info")]
        public Types.Task Task { get; set; } = default!;
    }
}
