namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /realname/verify 接口的响应。</para>
    /// </summary>
    public class GetRealNameVerificationResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置实名比对结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_result")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_result")]
        public int VerifyResult { get; set; }

        /// <summary>
        /// 获取或设置实名比对错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_message")]
        [System.Text.Json.Serialization.JsonPropertyName("err_message")]
        public string? VerifyErrorMessage { get; set; }
    }
}
