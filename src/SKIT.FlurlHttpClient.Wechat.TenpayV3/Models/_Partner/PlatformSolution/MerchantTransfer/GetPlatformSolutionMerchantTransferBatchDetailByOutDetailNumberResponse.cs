using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/mch-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetPlatformSolutionMerchantTransferBatchDetailByOutDetailNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置特约商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_no")]
        public string OutBatchNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string BatchId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_detail_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_detail_no")]
        public string OutDetailNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信明细单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_id")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_id")]
        public string DetailId { get; set; } = default!;

        /// <summary>
        /// 获取或设置明细状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_state")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_state")]
        public string DetailState { get; set; } = default!;

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
        public string TransferRemark { get; set; } = default!;

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
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款银行类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? BankType { get; set; }

        /// <summary>
        /// 获取或设置收款用户姓名（需使用商户私钥解密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_name")]
        [System.Text.Json.Serialization.JsonPropertyName("user_name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? UserName { get; set; }

        /// <summary>
        /// 获取或设置创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置转账完成时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_finish_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_finish_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? TransferFinishTime { get; set; }

        /// <summary>
        /// 获取或设置银行退票时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_refund_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("bank_refund_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? BankRefundTime { get; set; }
    }
}
