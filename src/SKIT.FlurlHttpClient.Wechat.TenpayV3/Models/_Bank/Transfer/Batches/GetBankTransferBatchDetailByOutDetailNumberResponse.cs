using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /bank-transfer/batches/out-batch-no/{out_batch_no}/details/out-detail-no/{out_detail_no} 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class GetBankTransferBatchDetailByOutDetailNumberResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置银行服务商号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_sp_mchid")]
        public string BankMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置服务平台商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("platform_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("platform_mchid")]
        public string PlatformMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款企业商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("specialized_payment_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("specialized_payment_mchid")]
        public string SpecializedPaymentMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置实际出资商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sponsor_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sponsor_mchid")]
        public string SponsorMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户授权商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_authorized_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_authorized_mchid")]
        public string UserAuthorizedMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户授权 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_authorized_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("user_authorized_appid")]
        public string UserAuthorizedAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置银行批次单号。
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
        public string DetailStatus { get; set; } = default!;

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
        /// 获取或设置转账场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_scene")]
        public string? TransferScene { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }

        /// <summary>
        /// 获取或设置收款账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款用户姓名（需使用商户私钥解密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string UserName { get; set; } = default!;

        /// <summary>
        /// 获取或设置银行名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_name")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
        public string? BankName { get; set; }

        /// <summary>
        /// 获取或设置银行卡尾号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_card_number_tail")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_card_number_tail")]
        public string? BankCardNumberTail { get; set; }

        /// <summary>
        /// 获取或设置转账发起时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("initiate_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("initiate_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset InitiateTime { get; set; }

        /// <summary>
        /// 获取或设置明细更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
