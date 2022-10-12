namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/get_temperature_data 接口的响应。</para>
    /// </summary>
    public class CgibinDeviceDataGetTemperatureDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class TemperatureDataList
            {
                /// <summary>
                /// 获取或设置温度检测数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public TemperatureDataItem[] Items { get; set; } = default!;
            }

            public class TemperatureDataItem
            {
                /// <summary>
                /// 获取或设置成员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_type")]
                [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                public int UserType { get; set; }

                /// <summary>
                /// 获取或设置成员的 OpenUserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string OpenUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置设备的序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                public string DeviceSerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置测温时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置测温温度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("temperature")]
                [System.Text.Json.Serialization.JsonPropertyName("temperature")]
                public string Temperature { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置温度检测数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("temperature_data")]
        [System.Text.Json.Serialization.JsonPropertyName("temperature_data")]
        public Types.TemperatureDataList TemperatureDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
