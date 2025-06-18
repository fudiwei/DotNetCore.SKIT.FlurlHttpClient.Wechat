using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/add_checkin_record 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinAddCheckinRecordRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Record
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
                public decimal? LocationLongitude { get; set; }

                /// <summary>
                /// 获取或设置打卡地点纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("lat")]
                [System.Text.Json.Serialization.JsonPropertyName("lat")]
                public decimal? LocationLatitude { get; set; }

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
                /// 获取或设置打卡设备类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_type")]
                [System.Text.Json.Serialization.JsonPropertyName("device_type")]
                public int? DeviceType { get; set; }

                /// <summary>
                /// 获取或设置打卡设备品牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("device_detail")]
                public string? DeviceDetail { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("notes")]
                [System.Text.Json.Serialization.JsonPropertyName("notes")]
                public string? Notes { get; set; }

                /// <summary>
                /// 获取或设置附件图片 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mediaids")]
                [System.Text.Json.Serialization.JsonPropertyName("mediaids")]
                public IList<string>? MediaIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置打卡记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("records")]
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public IList<Types.Record> RecordList { get; set; } = new List<Types.Record>();
    }
}
