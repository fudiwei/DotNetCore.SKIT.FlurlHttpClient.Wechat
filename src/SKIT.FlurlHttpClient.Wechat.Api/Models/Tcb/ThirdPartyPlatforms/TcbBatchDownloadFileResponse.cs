namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/batchdownloadfile 接口的响应。</para>
    /// </summary>
    public class TcbBatchDownloadFileResponse : WechatApiResponse
    {
        public static class Types
        {
            public class File
            {
                /// <summary>
                /// 获取或设置文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fileid")]
                [System.Text.Json.Serialization.JsonPropertyName("fileid")]
                public string FileId { get; set; } = default!;

                /// <summary>
                /// 获取或设置下载链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("download_url")]
                [System.Text.Json.Serialization.JsonPropertyName("download_url")]
                public string? DownloadUrl { get; set; }

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public Types.File[] FileList { get; set; } = default!;
    }
}
