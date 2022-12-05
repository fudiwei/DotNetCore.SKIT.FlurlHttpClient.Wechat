namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/get_device_token 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareGetDeviceTokenRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置设备型号凭证。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ModelAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
        public string DeviceSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备授权秘钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("device_secret")]
        public string DeviceSecret { get; set; } = string.Empty;
    }
}
