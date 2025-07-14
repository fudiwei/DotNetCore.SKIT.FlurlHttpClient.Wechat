namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 RISKTRADE.IDENTIFICATION 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013894258 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013894240 ]]>
    /// </para>
    /// </summary>
    public class RiskTradeIdentificationResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置风险类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_type")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_type")]
        public int RiskType { get; set; }

        /// <summary>
        /// 获取或设置风险等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_level")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_level")]
        public int RiskLevel { get; set; }
    }
}
