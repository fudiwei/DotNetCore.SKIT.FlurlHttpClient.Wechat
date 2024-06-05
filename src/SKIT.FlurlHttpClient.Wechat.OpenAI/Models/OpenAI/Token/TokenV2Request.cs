namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models
{
    /// <summary>
    /// <para>表示 [POST] /v2/token 接口的请求。</para>
    /// </summary>
    public class TokenV2Request : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置操作数据的管理员 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string AccountId { get; set; } = string.Empty;
    }
}
