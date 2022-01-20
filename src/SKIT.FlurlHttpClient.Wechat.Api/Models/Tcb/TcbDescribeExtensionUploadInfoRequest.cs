using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/describeextensionuploadinfo 接口的请求。</para>
    /// </summary>
    public class TcbDescribeExtensionUploadInfoRequest : WechatApiRequest
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
                        public string FileType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置文件名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("FileName")]
                        [System.Text.Json.Serialization.JsonPropertyName("FileName")]
                        public string FileName { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置待上传的文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ExtensionFiles")]
                [System.Text.Json.Serialization.JsonPropertyName("ExtensionFiles")]
                public IList<Types.ExtensionFile> ExtensionFileList { get; set; } = new List<Types.ExtensionFile>();
            }
        }

        /// <summary>
        /// 获取或设置上传数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PostData")]
        [System.Text.Json.Serialization.JsonPropertyName("PostData")]
        public Types.Data Data { get; set; } = new Types.Data();
    }
}
