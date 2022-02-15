using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/getcheckinoption 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinGetCheckinOptionRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定日期的时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("datetime")]
        [System.Text.Json.Serialization.JsonPropertyName("datetime")]
        public long DateTimestamp { get; set; }

        /// <summary>
        /// 获取或设置指定成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("useridlist")]
        [System.Text.Json.Serialization.JsonPropertyName("useridlist")]
        public IList<string> UserIdList { get; set; } = new List<string>();
    }
}
