namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /iotmanage/device-inspections/{device_sn} 接口的请求。</para>
    /// </summary>
    public class GetIoTManageDeviceInspectionByDeviceSerialNumberRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string DeviceSerialNumber { get; set; } = string.Empty;
    }
}
