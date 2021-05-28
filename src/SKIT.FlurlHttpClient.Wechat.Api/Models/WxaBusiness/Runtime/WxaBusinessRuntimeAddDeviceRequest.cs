using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/runtime/adddevice 接口的请求。</para>
    /// </summary>
    public class WxaBusinessRuntimeAddDeviceRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置产品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        /// <summary>
        /// 获取或设置设备 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_id_list")]
        public IList<string> DeviceIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置机型名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_name")]
        [System.Text.Json.Serialization.JsonPropertyName("model_name")]
        public string DeviceModelName { get; set; } = string.Empty;
    }
}
