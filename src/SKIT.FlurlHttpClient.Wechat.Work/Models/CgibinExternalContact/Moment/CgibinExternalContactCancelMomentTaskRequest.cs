namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/cancel_moment_task 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactCancelMomentTaskRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置朋友圈 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("moment_id")]
        public string MomentId { get; set; } = string.Empty;
    }
}
