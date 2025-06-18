using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_checkin_data 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportCheckinDataRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class CheckinData
            {
                /// <summary>
                /// 获取或设置成员的 OpenUserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string OpenUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置成员类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_type")]
                [System.Text.Json.Serialization.JsonPropertyName("user_type")]
                public int UserType { get; set; }

                /// <summary>
                /// 获取或设置上报时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timestamp")]
                [System.Text.Json.Serialization.JsonPropertyName("timestamp")]
                public long Timestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("checkin_data")]
        [System.Text.Json.Serialization.JsonPropertyName("checkin_data")]
        public IList<Types.CheckinData> TemperatureDataList { get; set; } = new List<Types.CheckinData>();
    }
}
