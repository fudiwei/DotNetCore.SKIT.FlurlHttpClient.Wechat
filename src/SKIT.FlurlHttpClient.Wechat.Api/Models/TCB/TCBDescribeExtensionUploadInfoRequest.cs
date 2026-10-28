namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/describeextensionuploadinfo 接口的请求。</para>
    /// </summary>
    public class TCBDescribeExtensionUploadInfoRequest : WechatApiRequest, IInferable<TCBDescribeExtensionUploadInfoRequest, TCBDescribeExtensionUploadInfoResponse>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ExtensionFile
                    {
                        /// <summary>
                        /// 获取或设置文件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("FileType")]
                        [System.Text.Json.Serialization.JsonPropertyName("FileType")]
                        public string? FileType { get; set; }

                        /// <summary>
                        /// 获取或设置文件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("FileName")]
                        [System.Text.Json.Serialization.JsonPropertyName("FileName")]
                        public string? FileName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置待上传的文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ExtensionFiles")]
                [System.Text.Json.Serialization.JsonPropertyName("ExtensionFiles")]
                public List<Types.ExtensionFile>? ExtensionFileList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置上传数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PostData")]
        [System.Text.Json.Serialization.JsonPropertyName("PostData")]
        public Types.Data? Data { get; set; }
    }
}
