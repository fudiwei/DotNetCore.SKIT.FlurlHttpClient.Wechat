namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/get_checkin_data 接口的响应。</para>
    /// </summary>
    public class CgibinDeviceDataGetCheckinDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CheckinDataList
            {
                /// <summary>
                /// 获取或设置打卡数据列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public CheckinDataItem[] Items { get; set; } = default!;
            }

            public class CheckinDataItem
            {
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
                /// 获取或设置上报时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("checkin_time")]
                public long Timestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkindata")]
        [System.Text.Json.Serialization.JsonPropertyName("checkindata")]
        public Types.CheckinDataList CheckinDataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
