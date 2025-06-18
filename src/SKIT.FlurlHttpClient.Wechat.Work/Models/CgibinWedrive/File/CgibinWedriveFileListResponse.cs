namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_list 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveFileListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class FileList
            {
                /// <summary>
                /// 获取或设置文件列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item")]
                [System.Text.Json.Serialization.JsonPropertyName("item")]
                public FileItem[] Items { get; set; } = default!;
            }

            public class FileItem
            {
                /// <summary>
                /// 获取或设置文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fileid")]
                [System.Text.Json.Serialization.JsonPropertyName("fileid")]
                public string FileId { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_name")]
                [System.Text.Json.Serialization.JsonPropertyName("file_name")]
                public string FileName { get; set; } = default!;

                /// <summary>
                /// 获取或设置空间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spaceid")]
                [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
                public string? SpaceId { get; set; }

                /// <summary>
                /// 获取或设置上级文件 ID 或空间 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fatherid")]
                [System.Text.Json.Serialization.JsonPropertyName("fatherid")]
                public string? ParentFileOrSpaceId { get; set; }

                /// <summary>
                /// 获取或设置文件大小（单位：字节）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_size")]
                [System.Text.Json.Serialization.JsonPropertyName("file_size")]
                public int? FileSize { get; set; }

                /// <summary>
                /// 获取或设置文件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_type")]
                [System.Text.Json.Serialization.JsonPropertyName("file_type")]
                public int? FileType { get; set; }

                /// <summary>
                /// 获取或设置文件状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("file_status")]
                [System.Text.Json.Serialization.JsonPropertyName("file_status")]
                public int? FileStatus { get; set; }

                /// <summary>
                /// 获取或设置文件创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ctime")]
                [System.Text.Json.Serialization.JsonPropertyName("ctime")]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置文件最后修改时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mtime")]
                [System.Text.Json.Serialization.JsonPropertyName("mtime")]
                public long? ModifyTimestamp { get; set; }

                /// <summary>
                /// 获取或设置文件 SHA 哈希值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sha")]
                [System.Text.Json.Serialization.JsonPropertyName("sha")]
                public string? FileSHA { get; set; }

                /// <summary>
                /// 获取或设置文件 MD5 哈希值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("md5")]
                [System.Text.Json.Serialization.JsonPropertyName("md5")]
                public string? FileMD5 { get; set; }

                /// <summary>
                /// 获取或设置访问链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? Url { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public Types.FileList FileList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_start")]
        [System.Text.Json.Serialization.JsonPropertyName("next_start")]
        public int? NextStart { get; set; }
    }
}
