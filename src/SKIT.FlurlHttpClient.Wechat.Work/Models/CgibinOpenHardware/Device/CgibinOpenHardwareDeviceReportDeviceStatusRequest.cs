namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_device_status 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportDeviceStatusRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置设备在线状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("online_status")]
        [System.Text.Json.Serialization.JsonPropertyName("online_status")]
        public int OnlineStatus { get; set; }

        /// <summary>
        /// 获取或设置当前固件版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cur_version")]
        [System.Text.Json.Serialization.JsonPropertyName("cur_version")]
        public string? CurrentVersion { get; set; }

        /// <summary>
        /// 获取或设置可升级固件版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upgradable_version")]
        [System.Text.Json.Serialization.JsonPropertyName("upgradable_version")]
        public string? UpgradableVersion { get; set; }

        /// <summary>
        /// 获取或设置可升级固件版本描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upgradable_version_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("upgradable_version_desc")]
        public string? UpgradableVersionDescription { get; set; }
    }
}
