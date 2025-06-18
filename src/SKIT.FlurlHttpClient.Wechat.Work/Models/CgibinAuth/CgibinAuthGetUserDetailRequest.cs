namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/auth/getuserdetail 接口的请求。</para>
    /// </summary>
    public class CgibinAuthGetUserDetailRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员票据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("user_ticket")]
        public string UserTicket { get; set; } = string.Empty;
    }
}
