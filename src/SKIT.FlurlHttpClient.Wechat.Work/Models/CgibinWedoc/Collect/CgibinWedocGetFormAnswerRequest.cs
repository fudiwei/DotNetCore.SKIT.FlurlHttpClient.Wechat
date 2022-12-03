using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedoc/get_form_answer 接口的请求。</para>
    /// </summary>
    public class CgibinWedocGetFormAnswerRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置收集表周期 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("repeated_id")]
        [System.Text.Json.Serialization.JsonPropertyName("repeated_id")]
        public string RepeatedId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置答案 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("answer_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("answer_ids")]
        public IList<long>? AnswerIdList { get; set; }
    }
}
