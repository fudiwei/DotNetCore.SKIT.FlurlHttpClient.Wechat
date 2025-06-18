namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/chatdata/get_hide_sensitiveinfo_config 接口的请求。</para>
    /// </summary>
    public class CgibinChatDataGetHideSensitiveInfoConfigRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员的密文 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
        public string OpenUserId { get; set; } = string.Empty;
    }
}
