namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/mch/customs/customdeclarequery 接口的响应。</para>
    /// </summary>
    public class QueryMerchantCustomsCustomDeclarationResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置笔数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("count")]
        [System.Text.Json.Serialization.JsonPropertyName("count")]
        public int Count { get; set; }

        // TODO:
        // $n 字段

        /// <summary>
        /// 获取或设置验核机构。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_department")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_department")]
        public string? VerifyDepartment { get; set; }

        /// <summary>
        /// 获取或设置验核机构交易流水号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_department_trade_id")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_department_trade_id")]
        public string? VerifyDepartmentTradeId { get; set; }
    }
}
