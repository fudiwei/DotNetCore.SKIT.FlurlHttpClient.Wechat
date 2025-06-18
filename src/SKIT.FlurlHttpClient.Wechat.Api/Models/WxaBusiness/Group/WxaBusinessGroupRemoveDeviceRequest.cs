using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/group/removedevice 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGroupRemoveDeviceRequest : WechatApiRequest, IInferable<WxaBusinessGroupRemoveDeviceRequest, WxaBusinessGroupRemoveDeviceResponse>
    {
        public static class Types
        {
            public class Device : WxaBusinessGroupAddDeviceRequest.Types.Device
            {
            }
        }

        /// <summary>
        /// 获取或设置设备组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string GroupId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public IList<Types.Device> DeviceList { get; set; } = new List<Types.Device>();
    }
}
