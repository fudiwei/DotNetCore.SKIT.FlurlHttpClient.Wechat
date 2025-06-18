using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/checkin/clear_checkin_option_array_field 接口的请求。</para>
    /// </summary>
    public class CgibinCheckinClearCheckinOptionArrayFieldRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置打卡规则 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("groupid")]
        [System.Text.Json.Serialization.JsonPropertyName("groupid")]
        public int GroupId { get; set; }

        /// <summary>
        /// 获取或设置清空的字段标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clear_field")]
        [System.Text.Json.Serialization.JsonPropertyName("clear_field")]
        public IList<int> ClearFieldKeyList { get; set; } = new List<int>();

        /// <summary>
        /// 获取或设置是否立即生效。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_now")]
        [System.Text.Json.Serialization.JsonPropertyName("effective_now")]
        public bool? IsEffectiveNow { get; set; }
    }
}
