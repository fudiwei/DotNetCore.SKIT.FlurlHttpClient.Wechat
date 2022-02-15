namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_move 接口的响应。</para>
    /// </summary>
    public class CgibinWebDriveFileMoveResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class FileList : CgibinWebDriveFileListResponse.Types.FileList
            {
            }
        }

        /// <summary>
        /// 获取或设置文件列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_list")]
        [System.Text.Json.Serialization.JsonPropertyName("file_list")]
        public Types.FileList FileList { get; set; } = default!;
    }
}
