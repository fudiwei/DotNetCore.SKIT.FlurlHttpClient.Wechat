namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /express/users/{openid}/transform 接口的请求。</para>
    /// </summary>
    public class TransformExpressUserOpenIdRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置目标应用的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;
    }
}
