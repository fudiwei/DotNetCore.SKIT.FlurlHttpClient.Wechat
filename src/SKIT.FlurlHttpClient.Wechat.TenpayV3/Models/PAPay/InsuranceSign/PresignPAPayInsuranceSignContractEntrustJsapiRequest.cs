using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /papay/insurance-sign/contracts/pre-entrust-sign/jsapi 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class PresignPAPayInsuranceSignContractEntrustJsapiRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount
            {
                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置货币类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }
            }

            public class PolicyPeriod
            {
                /// <summary>
                /// 获取或设置保险扣费周期编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("policy_period_id")]
                [System.Text.Json.Serialization.JsonPropertyName("policy_period_id")]
                public int PolicyPeriodId { get; set; }

                /// <summary>
                /// 获取或设置保险扣费周期编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("estimated_deduct_date")]
                [System.Text.Json.Serialization.JsonPropertyName("estimated_deduct_date")]
                public string EstimatedDeductDateString { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置预计扣费金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("estimated_deduct_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("estimated_deduct_amount")]
                public Types.Amount EstimatedDeductAmount { get; set; } = new Types.Amount();
            }

            public class RealIdentity
            {
                /// <summary>
                /// 获取或设置实名验证类型。
                /// <para>默认值："ID_CARD"</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity_type")]
                [System.Text.Json.Serialization.JsonPropertyName("identity_type")]
                public string IdentityType { get; set; } = "ID_CARD";

                /// <summary>
                /// 获取或设置真实姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("real_name")]
                [System.Text.Json.Serialization.JsonPropertyName("real_name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string RealName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string IdCardNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_id")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_id")]
        public long PlanId { get; set; }

        /// <summary>
        /// 获取或设置商户签约协议号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_contract_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_contract_code")]
        public string OutContractCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置被保人的展示名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("insured_display_name")]
        [System.Text.Json.Serialization.JsonPropertyName("insured_display_name")]
        public string InsuredDisplayAccount { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置签约结果回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contract_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("contract_notify_url")]
        public string ContractNotifyUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户侧用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_user_code")]
        [System.Text.Json.Serialization.JsonPropertyName("out_user_code")]
        public string? OutUserCode { get; set; }

        /// <summary>
        /// 获取或设置保险保单的开始日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_start_date")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_start_date")]
        public string PolicyStartDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险保单的结束日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_end_date")]
        public string PolicyEndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置保险保单的扣费周期列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("policy_periods")]
        [System.Text.Json.Serialization.JsonPropertyName("policy_periods")]
        public IList<Types.PolicyPeriod>? PolicyPeriodList { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置扣费金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount? Amount { get; set; }

        /// <summary>
        /// 获取或设置支付结果回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_notify_url")]
        public string? TransactionNotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置是否自动续保。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_auto_insure")]
        [System.Text.Json.Serialization.JsonPropertyName("can_auto_insure")]
        public bool? CanAutoInsure { get; set; }

        /// <summary>
        /// 获取或设置是否自动重新投保。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_auto_reinsure")]
        [System.Text.Json.Serialization.JsonPropertyName("can_auto_reinsure")]
        public bool? CanAutoReinsure { get; set; }

        /// <summary>
        /// 获取或设置用户实名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_identity")]
        [System.Text.Json.Serialization.JsonPropertyName("real_identity")]
        public Types.RealIdentity? RealIdentity { get; set; }
    }
}
