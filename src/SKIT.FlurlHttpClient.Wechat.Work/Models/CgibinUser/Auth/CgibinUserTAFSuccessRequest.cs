namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/tfa_succ 接口的请求。</para>
    /// </summary>
    public class CgibinUserTAFSuccessRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置二次验证授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfa_code")]
        [System.Text.Json.Serialization.JsonPropertyName("tfa_code")]
        public string TFACode { get; set; } = string.Empty;
    }
}
