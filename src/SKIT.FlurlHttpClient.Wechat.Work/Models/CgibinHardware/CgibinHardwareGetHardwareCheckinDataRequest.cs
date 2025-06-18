using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/hardware/get_hardware_checkin_data 接口的请求。</para>
    /// </summary>
    public class CgibinHardwareGetHardwareCheckinDataRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置过滤类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filter_type")]
        [System.Text.Json.Serialization.JsonPropertyName("filter_type")]
        public int? FilterType { get; set; }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("starttime")]
        [System.Text.Json.Serialization.JsonPropertyName("starttime")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
