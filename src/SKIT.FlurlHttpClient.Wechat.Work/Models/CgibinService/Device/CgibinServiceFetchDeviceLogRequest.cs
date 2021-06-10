using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/fetch_device_log 接口的请求。</para>
    /// </summary>
    public class CgibinServiceFetchDeviceLogRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置服务商 AccessToken。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AccessToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
        public string DeviceSerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提示参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hint")]
        [System.Text.Json.Serialization.JsonPropertyName("hint")]
        public string? Hint { get; set; }
    }
}
