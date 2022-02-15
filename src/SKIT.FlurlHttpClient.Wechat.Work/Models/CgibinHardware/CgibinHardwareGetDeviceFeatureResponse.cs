namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/hardware/get_device_feature 接口的响应。</para>
    /// </summary>
    public class CgibinHardwareGetDeviceFeatureResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置设备反馈的自定义标识串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_feature")]
        [System.Text.Json.Serialization.JsonPropertyName("device_feature")]
        public string DeviceFeature { get; set; } = default!;
    }
}
