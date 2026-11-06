namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchdownloadfile 接口的请求。</para>
    /// </summary>
    public class ComponentTCBBatchDownloadFileRequest : WechatApiRequest, IInferable<ComponentTCBBatchDownloadFileRequest, ComponentTCBBatchDownloadFileResponse>
    {
        public static class Types
        {
            public class File : TCBBatchDownloadFileRequest.Types.File
            {
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? ComponentAccessToken { get; set; }

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string? EnvironmentId { get; set; }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public List<Types.File>? FileList { get; set; }
    }
}
