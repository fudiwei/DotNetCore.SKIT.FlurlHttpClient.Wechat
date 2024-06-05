namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/bot/publish 接口的响应。</para>
    /// </summary>
    public class BotPublishV2Response : WechatOpenAIResponse<BotPublishV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data : WechatOpenAIResponseData
            {
            }
        }
    }
}
