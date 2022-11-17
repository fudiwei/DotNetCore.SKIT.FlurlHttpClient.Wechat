namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/getcodesecret 接口的响应。</para>
    /// </summary>
    public class TCBGetCodeSecretResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置代码保护密钥。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codesecret")]
        [System.Text.Json.Serialization.JsonPropertyName("codesecret")]
        public string CodeSecret { get; set; } = default!;
    }
}
