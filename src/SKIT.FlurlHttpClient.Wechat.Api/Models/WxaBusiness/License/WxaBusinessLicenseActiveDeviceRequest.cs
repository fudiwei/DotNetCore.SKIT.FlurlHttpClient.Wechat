using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/license/activedevice 接口的请求。</para>
    /// </summary>
    public class WxaBusinessLicenseActiveDeviceRequest : WechatApiRequest, IInferable<WxaBusinessLicenseActiveDeviceRequest, WxaBusinessLicenseActiveDeviceResponse>
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

                /// <summary>
                /// 获取或设置激活码序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("active_number")]
                [System.Text.Json.Serialization.JsonPropertyName("active_number")]
                public int ActiveNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public IList<Types.Device> DeviceList { get; set; } = new List<Types.Device>();

        /// <summary>
        /// 获取或设置资源包类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pkg_type")]
        [System.Text.Json.Serialization.JsonPropertyName("pkg_type")]
        public int PackageType { get; set; }
    }
}
