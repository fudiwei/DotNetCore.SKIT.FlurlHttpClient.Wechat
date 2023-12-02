namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/auth/get_tfa_info 接口的响应。</para>
    /// </summary>
    public class CgibinAuthGetTAFInfoResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置成员 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// 获取或设置二次验证授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tfa_code")]
        [System.Text.Json.Serialization.JsonPropertyName("tfa_code")]
        public string TFACode { get; set; } = default!;
    }
}
