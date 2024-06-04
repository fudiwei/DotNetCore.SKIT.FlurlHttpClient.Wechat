namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/token 接口的响应。</para>
    /// </summary>
    public class TokenV2Response : WechatOpenAIResponse<TokenV2Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置接口访问令牌。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("access_token")]
                [System.Text.Json.Serialization.JsonPropertyName("access_token")]
                public string AccessToken { get; set; } = default!;
            }
        }
    }
}
