namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/create_funds_bill 接口的响应。</para>
    /// </summary>
    public class XPayCreateFundsBillResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置充值单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_id")]
        public string BillId { get; set; } = default!;
    }
}
