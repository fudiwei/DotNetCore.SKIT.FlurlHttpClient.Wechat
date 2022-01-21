namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/get_list 接口的请求。</para>
    /// </summary>
    public class BotGetListRequest : WechatOpenAIThirdPartyRequest
    {
        /// <summary>
        /// 获取或设置关键字。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// 获取或设置机器人类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bot_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bot_type")]
        public int? BotType { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("size")]
        [System.Text.Json.Serialization.JsonPropertyName("size")]
        public int Limit { get; set; } = 10;
    }
}
