using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/getbucket 接口的响应。</para>
    /// </summary>
    public class ComponentTcbGetBucketResponse : WechatApiResponse
    {
        public static class Types
        {
            public class File
            {
                /// <summary>
                /// 获取或设置文件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string FileKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件的 MD5 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("md5")]
                [System.Text.Json.Serialization.JsonPropertyName("md5")]
                public string FileMd5 { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size")]
                [System.Text.Json.Serialization.JsonPropertyName("size")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int FileSize { get; set; }

                /// <summary>
                /// 获取或设置最近修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("last_modified")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("last_modified")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset LastModifiedTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contents")]
        [System.Text.Json.Serialization.JsonPropertyName("contents")]
        public Types.File[] FileList { get; set; } = default!;

        /// <summary>
        /// 获取或设置内容是否被截断。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_truncated")]
        [System.Text.Json.Serialization.JsonPropertyName("is_truncated")]
        public bool IsTruncated { get; set; }
    }
}
