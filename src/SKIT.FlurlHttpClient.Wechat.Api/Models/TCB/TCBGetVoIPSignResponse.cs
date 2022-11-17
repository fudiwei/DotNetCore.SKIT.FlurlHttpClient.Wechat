namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getvoipsign 接口的响应。</para>
    /// </summary>
    public class TCBGetVoIPSignResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置签名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signature")]
        [System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string Signature { get; set; } = default!;
    }
}
