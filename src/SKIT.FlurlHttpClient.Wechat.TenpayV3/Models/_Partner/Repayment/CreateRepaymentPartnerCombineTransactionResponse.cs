namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /repayment/combine-transactions/partner/prepay 接口的响应。</para>
    /// </summary>
    public class CreateRepaymentPartnerCombineTransactionResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置预支付交易会话标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string? PrepayId { get; set; }

        /// <summary>
        /// 获取或设置支付跳转链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h5_url")]
        [System.Text.Json.Serialization.JsonPropertyName("h5_url")]
        public string? H5Url { get; set; }
    }
}
