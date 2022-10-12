namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/get_auth_info 接口的响应。</para>
    /// </summary>
    public class CgibinDeviceDataGetAuthInfoResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class DeviceList
            {
                /// <summary>
                /// 获取或设置设备列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("item")]
                [System.Text.Json.Serialization.JsonPropertyName("item")]
                public DeviceItem[] Items { get; set; } = default!;
            }

            public class DeviceItem
            {
                /// <summary>
                /// 获取或设置设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_type")]
                [System.Text.Json.Serialization.JsonPropertyName("device_type")]
                public int DeviceType { get; set; }

                /// <summary>
                /// 获取或设置设备的序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                public string DeviceSerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备出厂型号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("model_name")]
                [System.Text.Json.Serialization.JsonPropertyName("model_name")]
                public string? ModelName { get; set; }

                /// <summary>
                /// 获取或设置设备出厂名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("default_name")]
                [System.Text.Json.Serialization.JsonPropertyName("default_name")]
                public string? DefaultName { get; set; }

                /// <summary>
                /// 获取或设置设备备注名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark_name")]
                [System.Text.Json.Serialization.JsonPropertyName("remark_name")]
                public string? RemarkName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置设备列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_list")]
        public Types.DeviceList DeviceList { get; set; } = default!;
    }
}
