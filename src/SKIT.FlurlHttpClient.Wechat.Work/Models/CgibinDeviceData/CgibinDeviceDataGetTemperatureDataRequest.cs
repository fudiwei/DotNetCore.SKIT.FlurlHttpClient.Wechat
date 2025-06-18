using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/devicedata/get_temperature_data 接口的请求。</para>
    /// </summary>
    public class CgibinDeviceDataGetTemperatureDataRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置成员类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_type")]
        [System.Text.Json.Serialization.JsonPropertyName("user_type")]
        public int UserType { get; set; }

        /// <summary>
        /// 获取或设置设备上传记录的开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_time")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
        public long BeginTimestamp { get; set; }

        /// <summary>
        /// 获取或设置设备上传记录的结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置温度检测数据筛选条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_filter_type")]
        [System.Text.Json.Serialization.JsonPropertyName("data_filter_type")]
        public int DataFilterType { get; set; }

        /// <summary>
        /// 获取或设置设备序列号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_sn_list")]
        [System.Text.Json.Serialization.JsonPropertyName("device_sn_list")]
        public IList<string>? DeviceSerialNumberList { get; set; }

        /// <summary>
        /// 获取或设置成员的 OpenUserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("open_userid_list")]
        public IList<string>? OpenUserIdList { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }
    }
}
