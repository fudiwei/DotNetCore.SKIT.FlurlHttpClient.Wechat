namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/get_model_token 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareGetModelTokenResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置设备型号凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("model_access_token")]
        public string ModelAccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备型号凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
