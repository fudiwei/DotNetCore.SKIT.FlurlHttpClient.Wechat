using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcheckindata 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinGetCheckinDataRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置打卡类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("opencheckindatatype")]
        [System.Text.Json.Serialization.JsonPropertyName("opencheckindatatype")]
        public int CheckinDataType { get; set; }

        /// <summary>
        /// 获取或设置指定记录的开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("starttime")]
        [System.Text.Json.Serialization.JsonPropertyName("starttime")]
        public long StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定记录的结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endtime")]
        [System.Text.Json.Serialization.JsonPropertyName("endtime")]
        public long EndTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
