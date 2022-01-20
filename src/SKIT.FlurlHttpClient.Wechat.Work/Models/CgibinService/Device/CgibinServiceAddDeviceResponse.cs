namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/add_device 接口的响应。</para>
    /// </summary>
    public class CgibinServiceAddDeviceResponse : WechatWorkResponse
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
                public string ModelId { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public long DeviceId { get; set; }

                /// <summary>
                /// 获取或设置设备序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                public string DeviceSerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备密钥。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secret_no")]
                [System.Text.Json.Serialization.JsonPropertyName("secret_no")]
                public string? SecretNumber { get; set; }

                /// <summary>
                /// 获取或设置设备二维码数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_code")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
                public string? QrcodeData { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设备信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_info")]
        [System.Text.Json.Serialization.JsonPropertyName("device_info")]
        public Types.Device Device { get; set; } = default!;
    }
}
