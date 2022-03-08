namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/save 接口的响应。</para>
    /// </summary>
    public class BotSaveResponse : WechatOpenAIThirdPartyResponse<BotSaveResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置机器人 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string BotId { get; set; } = default!;
            }
        }
    }
}
