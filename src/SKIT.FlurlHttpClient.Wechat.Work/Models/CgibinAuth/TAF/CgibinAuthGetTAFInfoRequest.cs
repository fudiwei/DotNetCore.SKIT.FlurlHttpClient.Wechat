namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/auth/get_tfa_info 接口的请求。</para>
    /// </summary>
    public class CgibinAuthGetTAFInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置用户二次验证 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string Code { get; set; } = string.Empty;
    }
}
