namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_rename 接口的响应。</para>
    /// </summary>
    public class CgibinWebDriveFileRenameResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class File : CgibinWebDriveFileInfoResponse.Types.File
            {
            }
        }

        /// <summary>
        /// 获取或设置文件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file")]
        [System.Text.Json.Serialization.JsonPropertyName("file")]
        public Types.File File { get; set; } = default!;
    }
}
