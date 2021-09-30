namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/kf/service_state/get 接口的请求。</para>
    /// </summary>
    public class CgibinKfServiceStateGetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置客服账号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_kfid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_kfid")]
        public string OpenKfId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置外部联系人账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("external_userid")]
        public string ExternalUserId { get; set; } = string.Empty;
    }
}
