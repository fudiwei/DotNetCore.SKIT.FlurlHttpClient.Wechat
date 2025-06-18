namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/update 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingUpdateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效会议帐号 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("excess_users")]
        [System.Text.Json.Serialization.JsonPropertyName("excess_users")]
        public string[]? ExcessUserIdList { get; set; }
    }
}
