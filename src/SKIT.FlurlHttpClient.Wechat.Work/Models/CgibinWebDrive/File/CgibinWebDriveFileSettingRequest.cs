namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/file_setting 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveFileSettingRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置操作者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fileid")]
        [System.Text.Json.Serialization.JsonPropertyName("fileid")]
        public string FileId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置权限范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_scope")]
        public int AuthScope { get; set; }

        /// <summary>
        /// 获取或设置权限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth")]
        [System.Text.Json.Serialization.JsonPropertyName("auth")]
        public int? Authority { get; set; }
    }
}
