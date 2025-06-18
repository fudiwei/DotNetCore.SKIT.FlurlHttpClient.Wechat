namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /eduschoolpay/contracts/presign 接口的响应。</para>
    /// </summary>
    public class PresignEducationSchoolPayContractResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预签约码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("presign_token")]
        [System.Text.Json.Serialization.JsonPropertyName("presign_token")]
        public string PresignToken { get; set; } = default!;
    }
}
