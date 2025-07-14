namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /platsolution/ecommerce/settle/prepay-settle-orders/{settle_batch_no}/apply-abnormal-settle 接口的请求。</para>
    /// </summary>
    public class ApplyPlatformSolutionEcommerceSettlePrepaySettleOrderAbnormalSettleRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置个人收款方受理授权 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual_auth_id")]
        [System.Text.Json.Serialization.JsonPropertyName("individual_auth_id")]
        public string? IndividualAuthId { get; set; }

        /// <summary>
        /// 获取或设置微信支付结算批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SettleBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户异常结算批次单处理单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_abnormal_settle_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_abnormal_settle_batch_no")]
        public string OutAbnormalSettleBatchNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置异常处理方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("abnormal_settle_type")]
        [System.Text.Json.Serialization.JsonPropertyName("abnormal_settle_type")]
        public string AbnormalSettleType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置异常处理说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}
