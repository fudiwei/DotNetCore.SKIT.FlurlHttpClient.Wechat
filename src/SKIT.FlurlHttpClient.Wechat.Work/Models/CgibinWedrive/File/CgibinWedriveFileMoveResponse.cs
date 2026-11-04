namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_move 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveFileMoveResponse : WechatWorkResponse
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
                public List<FileItem>? Items { get; set; }
            }

            public class FileItem : CgibinWedriveFileListResponse.Types.FileItem
            {
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public Types.FileList? FileList { get; set; }
    }
}
