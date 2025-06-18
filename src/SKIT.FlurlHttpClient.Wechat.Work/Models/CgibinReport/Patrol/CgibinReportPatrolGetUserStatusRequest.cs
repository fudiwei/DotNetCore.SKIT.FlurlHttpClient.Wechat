namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/patrol/get_user_status 接口的请求。</para>
    /// </summary>
    public class CgibinReportPatrolGetUserStatusRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;
    }
}
