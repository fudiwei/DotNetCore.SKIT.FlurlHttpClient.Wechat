namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /express/users/{openid}/transform 接口的响应。</para>
    /// </summary>
    public class TransformExpressUserOpenIdResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置转换后的用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;
    }
}
