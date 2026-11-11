namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /partner-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetPartnerTransferBatchDetailByOutDetailNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string? OutBatchNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string? BatchId { get; set; }

        /// <summary>
        /// 获取或设置商户明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_detail_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
        public string? OutDetailNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_id")]
        public string? DetailId { get; set; }

        /// <summary>
        /// 获取或设置明细状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_status")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_status")]
        public string? DetailStatus { get; set; }

        /// <summary>
        /// 获取或设置转账金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_amount")]
        public int TransferAmount { get; set; }

        /// <summary>
        /// 获取或设置转账备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_remark")]
        public string? TransferRemark { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置收款用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置收款用户姓名。
        /// </summary>
        /// <remarks>
        /// 该属性是敏感数据字段，需要使用商户私钥解密。
        /// </remarks>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置转账发起时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("initiate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("initiate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset InitiateTime { get; set; }

        /// <summary>
        /// 获取或设置明细更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
