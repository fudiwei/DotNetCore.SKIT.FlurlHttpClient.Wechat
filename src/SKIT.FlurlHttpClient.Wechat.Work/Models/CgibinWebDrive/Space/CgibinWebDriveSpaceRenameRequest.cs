namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/space_rename 接口的请求。</para>
    /// </summary>
    public class CgibinWebDriveSpaceRenameRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置操作者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置空间 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spaceid")]
        [System.Text.Json.Serialization.JsonPropertyName("spaceid")]
        public string SpaceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置空间标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("space_name")]
        [System.Text.Json.Serialization.JsonPropertyName("space_name")]
        public string SpaceName { get; set; } = string.Empty;
    }
}
