using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/group/adddevice 接口的请求。</para>
    /// </summary>
    public class WxaBusinessGroupAddDeviceRequest : WechatApiRequest, IInferable<WxaBusinessGroupAddDeviceRequest, WxaBusinessGroupAddDeviceResponse>
    {
        public static class Types
        {
            public class Device
            {
                /// <summary>
                /// 获取或设置设备型号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model_id")]
                [System.Text.Json.Serialization.JsonPropertyName("model_id")]
                public string ModelId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置设备序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sn")]
                [System.Text.Json.Serialization.JsonPropertyName("sn")]
                public string SerialNumber { get; set; } = string.Empty;
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

        /// <summary>
        /// 获取或设置是否强制添加。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("force_add")]
        [System.Text.Json.Serialization.JsonPropertyName("force_add")]
        public bool? IsForceAdd { get; set; }
    }
}
