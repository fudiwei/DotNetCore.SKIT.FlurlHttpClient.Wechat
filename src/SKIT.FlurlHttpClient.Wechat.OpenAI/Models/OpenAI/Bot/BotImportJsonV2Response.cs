namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/import/json 接口的响应。</para>
    /// </summary>
    public class BotImportJsonV2Response : WechatOpenAIResponse<BotImportJsonV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : WechatOpenAIResponseData
            {
                /// <summary>
                /// 获取或设置任务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("task_id")]
                [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                public string TaskId { get; set; } = default!;
            }
        }
    }
}
