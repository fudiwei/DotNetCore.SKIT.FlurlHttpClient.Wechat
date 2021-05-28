using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/describeextensionuploadinfo 接口的响应。</para>
    /// </summary>
    public class TcbDescribeExtensionUploadInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class File
                    {
                        /// <summary>
                        /// 获取或设置模板里使用的地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CodeUri")]
                        [System.Text.Json.Serialization.JsonPropertyName("CodeUri")]
                        public string CodeUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置上传文件的临时地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("UploadUrl")]
                        [System.Text.Json.Serialization.JsonPropertyName("UploadUrl")]
                        public string UploadUrl { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置自定义密钥。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("CustomKey")]
                        [System.Text.Json.Serialization.JsonPropertyName("CustomKey")]
                        public string? CustomKey { get; set; }

                        /// <summary>
                        /// 获取或设置文件大小限制（单位：MB）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("MaxSize")]
                        [System.Text.Json.Serialization.JsonPropertyName("MaxSize")]
                        public int MaxSize { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置文件信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("FilesData")]
                [System.Text.Json.Serialization.JsonPropertyName("FilesData")]
                public Types.File[] FileList { get; set; } = default!;

                /// <summary>
                /// 获取或设置唯一请求 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("RequestId")]
                [System.Text.Json.Serialization.JsonPropertyName("RequestId")]
                public string RequestId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置响应数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Response")]
        [System.Text.Json.Serialization.JsonPropertyName("Response")]
        public Types.Data Data { get; set; } = default!;
    }
}
