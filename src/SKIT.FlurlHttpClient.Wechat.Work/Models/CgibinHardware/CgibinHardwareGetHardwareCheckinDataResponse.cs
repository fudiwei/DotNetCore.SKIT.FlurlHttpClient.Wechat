namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/hardware/get_hardware_checkin_data 接口的响应。</para>
    /// </summary>
    public class CgibinHardwareGetHardwareCheckinDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CheckinData
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置打卡时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("checkin_time")]
                public long CheckinTimestamp { get; set; }

                /// <summary>
                /// 获取或设置打卡设备的序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_sn")]
                [System.Text.Json.Serialization.JsonPropertyName("device_sn")]
                public string DeviceSerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置打卡设备的名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_name")]
                [System.Text.Json.Serialization.JsonPropertyName("device_name")]
                public string DeviceName { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置打卡数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkindata")]
        [System.Text.Json.Serialization.JsonPropertyName("checkindata")]
        public Types.CheckinData[] CheckinDataList { get; set; } = default!;
    }
}
