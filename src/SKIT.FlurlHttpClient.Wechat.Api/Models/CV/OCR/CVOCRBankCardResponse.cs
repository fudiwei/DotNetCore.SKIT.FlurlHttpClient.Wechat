namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/bankcard 接口的响应。</para>
    /// </summary>
    public class CVOCRBankCardResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置银行卡号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("number")]
        [System.Text.Json.Serialization.JsonPropertyName("number")]
        public string BankNumber { get; set; } = default!;
    }
}
