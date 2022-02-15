namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/soter/verify_signature 接口的请求。</para>
    /// </summary>
    public class GgibinSoterVerifySignatureRequest : WechatApiRequest, IMapResponse<GgibinSoterVerifySignatureRequest, GgibinSoterVerifySignatureResponse>
    {
        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置通过 `wx.startSoterAuthentication` 成功回调获得的 `resultJSON` 字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("json_string")]
        [System.Text.Json.Serialization.JsonPropertyName("json_string")]
        public string JsonString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置通过 `wx.startSoterAuthentication` 成功回调获得的 `resultJSONSignature` 字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("json_signature")]
        [System.Text.Json.Serialization.JsonPropertyName("json_signature")]
        public string JsonSignature { get; set; } = string.Empty;
    }
}
