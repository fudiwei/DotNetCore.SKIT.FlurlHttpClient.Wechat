namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/get_accesscontrol_data 接口的响应。</para>
    /// </summary>
    public class CgibinDeviceDataGetAccessControlDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AccessControlDataList
            {
                /// <summary>
                /// 获取或设置门禁通行数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public AccessControlDataItem[] Items { get; set; } = default!;
            }

            public class AccessControlDataItem
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
                /// 获取或设置通行时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置通行类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pass_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pass_type")]
                public int PassType { get; set; }

                /// <summary>
                /// 获取或设置通行方法。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pass_method")]
                [System.Text.Json.Serialization.JsonPropertyName("pass_method")]
                public int PassMethod { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置门禁通行数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accesscontrol_data")]
        [System.Text.Json.Serialization.JsonPropertyName("accesscontrol_data")]
        public Types.AccessControlDataList AccessControlDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
