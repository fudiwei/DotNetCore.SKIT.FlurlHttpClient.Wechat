using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/openhw/device/report_temperature_data 接口的请求。</para>
    /// </summary>
    public class CgibinOpenHardwareDeviceReportTemperatureDataRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class TemperatureData
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

                /// <summary>
                /// 获取或设置温度字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("temperature")]
                [System.Text.Json.Serialization.JsonPropertyName("temperature")]
                public string TemperatureString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置温度状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置测温数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("temperature_data")]
        [System.Text.Json.Serialization.JsonPropertyName("temperature_data")]
        public IList<Types.TemperatureData> TemperatureDataList { get; set; } = new List<Types.TemperatureData>();
    }
}
