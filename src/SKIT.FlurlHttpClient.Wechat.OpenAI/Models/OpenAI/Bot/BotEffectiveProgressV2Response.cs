namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/effective_progress 接口的响应。</para>
    /// </summary>
    public class BotEffectiveProgressV2Response : WechatOpenAIResponse<BotEffectiveProgressV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : WechatOpenAIResponseData
            {
                /// <summary>
                /// 获取或设置任务状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置任务进度（单位：百分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("progress")]
                [System.Text.Json.Serialization.JsonPropertyName("progress")]
                public int Progress { get; set; }

                /// <summary>
                /// 获取或设置任务结束时间字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public string? EndTimeString { get; set; }
            }
        }
    }
}
