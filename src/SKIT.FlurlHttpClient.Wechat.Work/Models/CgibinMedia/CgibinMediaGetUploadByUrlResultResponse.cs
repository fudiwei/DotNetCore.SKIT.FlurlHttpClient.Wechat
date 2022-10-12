namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/get_upload_by_url_result 接口的响应。</para>
    /// </summary>
    public class CgibinMediaGetUploadByUrlResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置任务返回码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置任务错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }

                /// <summary>
                /// 获取或设置媒体文件标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("media_id")]
                public string? MediaId { get; set; }

                /// <summary>
                /// 获取或设置媒体文件上传时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("created_at")]
                [System.Text.Json.Serialization.JsonPropertyName("created_at")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置任务状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置任务结果信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Result Result { get; set; } = default!;
    }
}
