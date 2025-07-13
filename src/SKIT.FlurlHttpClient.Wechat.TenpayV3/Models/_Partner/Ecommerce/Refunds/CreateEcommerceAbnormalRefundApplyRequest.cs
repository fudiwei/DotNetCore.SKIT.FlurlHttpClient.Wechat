namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /ecommerce/refunds/{refund_id}/apply-abnormal-refund 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateEcommerceAbnormalRefundApplyRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Amount
            {
                /// <summary>
                /// 获取或设置原订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund")]
                [System.Text.Json.Serialization.JsonPropertyName("refund")]
                public int Refund { get; set; }

                /// <summary>
                /// 获取或设置退款币种。
                /// <para>默认值："CNY"</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string Currency { get; set; } = "CNY";
            }
        }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置还款服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string? CombineMerchantId { get; set; }

        /// <summary>
        /// 获取或设置还款商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string? CombineOutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置微信退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string RefundId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置个人收款方受理授权 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("individual_auth_id")]
        [System.Text.Json.Serialization.JsonPropertyName("individual_auth_id")]
        public string? IndividualAuthId { get; set; }

        /// <summary>
        /// 获取或设置异常退款处理方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置收款开户银行。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_type")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_type")]
        public string? BankName { get; set; }

        /// <summary>
        /// 获取或设置收款银行卡号（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? BankAccountNumber { get; set; }

        /// <summary>
        /// 获取或设置收款用户姓名（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("real_name")]
        [System.Text.Json.Serialization.JsonPropertyName("real_name")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? RealName { get; set; }
    }
}
