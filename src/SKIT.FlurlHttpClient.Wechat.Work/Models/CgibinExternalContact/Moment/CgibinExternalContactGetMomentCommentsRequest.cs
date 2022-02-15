namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/get_moment_comments 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGetMomentCommentsRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置朋友圈 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("moment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("moment_id")]
        public string MomentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发布者成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;
    }
}
