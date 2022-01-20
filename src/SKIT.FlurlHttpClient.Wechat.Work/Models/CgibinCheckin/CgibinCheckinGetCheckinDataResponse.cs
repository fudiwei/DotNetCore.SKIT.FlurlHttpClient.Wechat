namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcheckindata 接口的响应。</para>
    /// </summary>
    public class CgibinCheckinGetCheckinDataResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置打卡规则 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupid")]
                [System.Text.Json.Serialization.JsonPropertyName("groupid")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置打卡规则名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("groupname")]
                [System.Text.Json.Serialization.JsonPropertyName("groupname")]
                public string GroupName { get; set; } = default!;

                /// <summary>
                /// 获取或设置打卡类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkin_type")]
                [System.Text.Json.Serialization.JsonPropertyName("checkin_type")]
                public string CheckinType { get; set; } = default!;

                /// <summary>
                /// 获取或设置异常类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exception_type")]
                [System.Text.Json.Serialization.JsonPropertyName("exception_type")]
                public string ExceptionType { get; set; } = default!;

                /// <summary>
                /// 获取或设置打卡时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("checkin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("checkin_time")]
                public long CheckinTimestamp { get; set; }

                /// <summary>
                /// 获取或设置标准打卡时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sch_checkin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("sch_checkin_time")]
                public long StandardCheckinTimestamp { get; set; }

                /// <summary>
                /// 获取或设置打卡地点名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location_title")]
                [System.Text.Json.Serialization.JsonPropertyName("location_title")]
                public string? LocationTitle { get; set; }

                /// <summary>
                /// 获取或设置打卡地点详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("location_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("location_detail")]
                public string? LocationDetail { get; set; }

                /// <summary>
                /// 获取或设置打卡地点经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lng")]
                [System.Text.Json.Serialization.JsonPropertyName("lng")]
                public double? LocationLongitude { get; set; }

                /// <summary>
                /// 获取或设置打卡地点纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lat")]
                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                public double? LocationLatitude { get; set; }

                /// <summary>
                /// 获取或设置打卡 Wi-Fi 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wifiname")]
                [System.Text.Json.Serialization.JsonPropertyName("wifiname")]
                public string? WiFiName { get; set; }

                /// <summary>
                /// 获取或设置打卡 Wi-Fi 的 MAC 地址或 BSSID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wifimac")]
                [System.Text.Json.Serialization.JsonPropertyName("wifimac")]
                public string? WiFiMac { get; set; }

                /// <summary>
                /// 获取或设置打卡设备号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deviceid")]
                [System.Text.Json.Serialization.JsonPropertyName("deviceid")]
                public string? DeviceId { get; set; }

                /// <summary>
                /// 获取或设置排班 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("schedule_id")]
                [System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
                public int? ScheduleId { get; set; }

                /// <summary>
                /// 获取或设置时段 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timeline_id")]
                [System.Text.Json.Serialization.JsonPropertyName("timeline_id")]
                public int? TimeSectionId { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notes")]
                [System.Text.Json.Serialization.JsonPropertyName("notes")]
                public string? Notes { get; set; }

                /// <summary>
                /// 获取或设置备注附件图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mediaids")]
                [System.Text.Json.Serialization.JsonPropertyName("mediaids")]
                public string[]? NotesMediaIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkindata")]
        [System.Text.Json.Serialization.JsonPropertyName("checkindata")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
