namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/get_device_secret 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareGetDeviceSecretRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置设备型号凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ModelAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        public string AuthCode { get; set; } = string.Empty;
    }
}
