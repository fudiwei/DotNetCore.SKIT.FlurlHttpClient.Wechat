namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/acquiringbank/serviceorder/{out_order_no}/registerdeductinfo 接口的响应。</para>
    /// </summary>
    public class RegisterPayScoreAcquiringBankServiceOrderDeductionResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;
    }
}
