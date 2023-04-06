namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/acquiringbank/serviceorder 接口的响应。</para>
    /// </summary>
    public class CreatePayScoreAcquiringBankServiceOrderResponse : GetPayScoreAcquiringBankServiceOrderByOutOrderNumberResponse
    {
        /// <summary>
        /// 获取或设置跳转微信侧小程序订单数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("package")]
        [System.Text.Json.Serialization.JsonPropertyName("package")]
        public string Package { get; set; } = default!;
    }
}
