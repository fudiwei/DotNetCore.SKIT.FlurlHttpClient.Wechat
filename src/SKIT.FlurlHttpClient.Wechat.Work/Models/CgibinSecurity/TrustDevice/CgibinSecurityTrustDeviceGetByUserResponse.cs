namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/security/trustdevice/get_by_user 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityTrustDeviceGetByUserResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Device : CgibinSecurityTrustDeviceListResponse.Types.Device
            {
            }
        }

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public Types.Device[] DeviceList { get; set; } = default!;
    }
}
