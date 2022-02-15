namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_groupmsg_send_result 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetGroupMessageSendResultRequest : CgibinExternalContactGetGroupMessageTaskRequest
    {
        /// <summary>
        /// 获取或设置发送成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;
    }
}
