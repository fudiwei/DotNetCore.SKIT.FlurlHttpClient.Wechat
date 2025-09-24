using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /iotmanage/device-inspections/{device_sn} 接口的响应。</para>
    /// </summary>
    public class GetIoTManageDeviceInspectionByDeviceSerialNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置设备序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
        public string DeviceSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置摄像头序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("camera_sn")]
        [System.Text.Json.Serialization.JsonPropertyName("camera_sn")]
        public string CameraSerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置有线网卡 MAC 地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wired_mac")]
        [System.Text.Json.Serialization.JsonPropertyName("wired_mac")]
        public string WiredMAC { get; set; } = default!;

        /// <summary>
        /// 获取或设置无线网卡 MAC 地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wireless_mac")]
        [System.Text.Json.Serialization.JsonPropertyName("wireless_mac")]
        public string WirelessMAC { get; set; } = default!;

        /// <summary>
        /// 获取或设置蓝牙 MAC 地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bluetooth_mac")]
        [System.Text.Json.Serialization.JsonPropertyName("bluetooth_mac")]
        public string BluetoothMAC { get; set; } = default!;

        /// <summary>
        /// 获取或设置应用版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_version")]
        [System.Text.Json.Serialization.JsonPropertyName("app_version")]
        public string AppVersion { get; set; } = default!;

        /// <summary>
        /// 获取或设置国际移动设备识别码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("imei")]
        [System.Text.Json.Serialization.JsonPropertyName("imei")]
        public string IMEI { get; set; } = default!;

        /// <summary>
        /// 获取或设置国际移动设备识别码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;

        /// <summary>
        /// 获取或设置检测时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("inspect_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("inspect_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset InspectTime { get; set; }

        /// <summary>
        /// 获取或设置错误信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errors")]
        [System.Text.Json.Serialization.JsonPropertyName("errors")]
        public string[]? ErrorList { get; set; }

        /// <summary>
        /// 获取或设置警告信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("warnings")]
        [System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public string[]? WarningList { get; set; }
    }
}
