namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchdownloadfile 接口的响应。</para>
    /// </summary>
    public class ComponentTCBBatchDownloadFileResponse : WechatApiResponse
    {
        public static class Types
        {
            public class File : TCBBatchDownloadFileResponse.Types.File
            {
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public List<Types.File>? FileList { get; set; }
    }
}
