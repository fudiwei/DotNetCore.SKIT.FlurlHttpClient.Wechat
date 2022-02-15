using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/batchdownloadfile 接口的请求。</para>
    /// </summary>
    public class ComponentTcbBatchDownloadFileRequest : WechatApiRequest, IMapResponse<ComponentTcbBatchDownloadFileRequest, ComponentTcbBatchDownloadFileResponse>
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
                public string FileId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置下载链接有效期（单位：秒）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("max_age")]
                [System.Text.Json.Serialization.JsonPropertyName("max_age")]
                public int MaxAge { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方平台 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ComponentAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置环境 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env")]
        [System.Text.Json.Serialization.JsonPropertyName("env")]
        public string EnvironmentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public IList<Types.File> FileList { get; set; } = new List<Types.File>();
    }
}
