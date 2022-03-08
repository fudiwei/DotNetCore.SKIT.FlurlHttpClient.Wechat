namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v1/openapi/create 接口的响应。</para>
    /// </summary>
    public class OpenApiCreateResponse : WechatOpenAIThirdPartyResponse<OpenApiCreateResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("token")]
                [System.Text.Json.Serialization.JsonPropertyName("token")]
                public string Token { get; set; } = default!;

                /// <summary>
                /// 获取或设置 EncodingAESKey。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aes_key")]
                [System.Text.Json.Serialization.JsonPropertyName("aes_key")]
                public string EncodingAESKey { get; set; } = default!;
            }
        }
    }
}
