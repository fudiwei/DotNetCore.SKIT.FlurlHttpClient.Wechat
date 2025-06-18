namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/add_device 接口的请求。</para>
    /// </summary>
    public class CgibinServiceAddDeviceRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ProviderAccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备型号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        [System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
        public string DeviceSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置备注名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remark_name")]
        [System.Text.Json.Serialization.JsonPropertyName("remark_name")]
        public string? RemarkName { get; set; }
    }
}
