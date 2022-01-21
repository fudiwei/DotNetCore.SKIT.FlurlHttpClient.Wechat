namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill/get_detail 接口的请求。</para>
    /// </summary>
    public class SkillGetDetailRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置关键字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// 获取或设置技能 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("skill_id")]
        public long SkillId { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int Limit { get; set; } = 10;
    }
}
