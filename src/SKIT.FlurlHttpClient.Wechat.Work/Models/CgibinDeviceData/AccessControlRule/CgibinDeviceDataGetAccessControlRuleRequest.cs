namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/get_accesscontrol_rule 接口的请求。</para>
    /// </summary>
    public class CgibinDeviceDataGetAccessControlRuleRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
        public string DeviceSerialNumberList { get; set; } = string.Empty;
    }
}
