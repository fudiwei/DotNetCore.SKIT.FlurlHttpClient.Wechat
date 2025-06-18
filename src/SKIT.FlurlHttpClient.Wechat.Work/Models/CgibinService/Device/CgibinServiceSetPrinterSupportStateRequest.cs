namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/set_printer_support_state 接口的请求。</para>
    /// </summary>
    public class CgibinServiceSetPrinterSupportStateRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
        public string DeviceSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否不支持打印机。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("not_supported_printer")]
        [System.Text.Json.Serialization.JsonPropertyName("not_supported_printer")]
        public bool IsUnsupportedPrinter { get; set; }
    }
}
