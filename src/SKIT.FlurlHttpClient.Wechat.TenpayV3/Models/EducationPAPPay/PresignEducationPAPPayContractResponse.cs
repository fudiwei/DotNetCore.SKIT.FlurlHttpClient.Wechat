namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /edu-papay/contracts/presign 接口的响应。</para>
    /// </summary>
    public class PresignEducationPAPPayContractResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预签约号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("presign_token")]
        [System.Text.Json.Serialization.JsonPropertyName("presign_token")]
        public string PresignToken { get; set; } = default!;
    }
}
