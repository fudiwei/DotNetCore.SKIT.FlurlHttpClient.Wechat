namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/get_device_secret 接口的响应。</para>
    /// </summary>
    public class CgibinOpenHardwareGetDeviceSecretResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置设备授权密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_secret")]
        [System.Text.Json.Serialization.JsonPropertyName("device_secret")]
        public string DeviceSecret { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备接口调用凭证。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("device_access_token")]
        public string DeviceAccessToken { get; set; } = default!;

        /// <summary>
        /// 获取或设置设备接口调用凭证有效期（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expires_in")]
        [System.Text.Json.Serialization.JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }
    }
}
