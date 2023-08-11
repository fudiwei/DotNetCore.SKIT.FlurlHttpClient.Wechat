namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-risk-manage/report-trade-union-information 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateMerchantRiskManageTradeUnionInformationReportRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class RechargeField
            {
                /// <summary>
                /// 获取或设置充值账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public int? AccountType { get; set; }

                /// <summary>
                /// 获取或设置充值账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account")]
                [System.Text.Json.Serialization.JsonPropertyName("account")]
                public string? Account { get; set; }
            }

            public class LivingExpensesField
            {
                /// <summary>
                /// 获取或设置户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acc_no")]
                [System.Text.Json.Serialization.JsonPropertyName("acc_no")]
                public string? AccountNumber { get; set; }

                /// <summary>
                /// 获取或设置户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acc_name")]
                [System.Text.Json.Serialization.JsonPropertyName("acc_name")]
                public string? AccountName { get; set; }

                /// <summary>
                /// 获取或设置费种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int? Type { get; set; }

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }

                /// <summary>
                /// 获取或设置地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置机构名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string? CompanyName { get; set; }

                /// <summary>
                /// 获取或设置缴费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int? Amount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置从业机构号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquiring_bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_id")]
        public string? AcquiringBankId { get; set; }

        /// <summary>
        /// 获取或设置渠道号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户手机号（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置用户实名证件号（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("certificates_number")]
        [System.Text.Json.Serialization.JsonPropertyName("certificates_number")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? IdCardNumber { get; set; }

        /// <summary>
        /// 获取或设置终端 IP。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_ip")]
        [System.Text.Json.Serialization.JsonPropertyName("client_ip")]
        public string? ClientIp { get; set; }

        /// <summary>
        /// 获取或设置商户判定交易的风险等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_level")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_level")]
        public int? RiskLevel { get; set; }

        /// <summary>
        /// 获取或设置线上线下标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("line_type")]
        [System.Text.Json.Serialization.JsonPropertyName("line_type")]
        public int? LineType { get; set; }

        /// <summary>
        /// 获取或设置虚拟实物标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_type")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_type")]
        public int? GoodsType { get; set; }

        /// <summary>
        /// 获取或设置物品发布类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_type")]
        [System.Text.Json.Serialization.JsonPropertyName("seller_type")]
        public int? SellerType { get; set; }

        /// <summary>
        /// 获取或设置是否需要物流发货。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_need_deliver")]
        [System.Text.Json.Serialization.JsonPropertyName("is_need_deliver")]
        public bool? IsNeedDeliver { get; set; }

        /// <summary>
        /// 获取或设置用户设备类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("device_type")]
        [System.Text.Json.Serialization.JsonPropertyName("device_type")]
        public int? DeviceType { get; set; }

        /// <summary>
        /// 获取或设置付款方用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string? UserId { get; set; }

        /// <summary>
        /// 获取或设置手机号来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_from")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_from")]
        public int? PhoneFrom { get; set; }

        /// <summary>
        /// 获取或设置收款方用户标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seller_userid")]
        [System.Text.Json.Serialization.JsonPropertyName("seller_userid")]
        public string? SellerUserId { get; set; }

        /// <summary>
        /// 获取或设置业务场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public int? Scene { get; set; }

        /// <summary>
        /// 获取或设置充值业务场景字段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_fields")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_fields")]
        public Types.RechargeField? RechargeField { get; set; }

        /// <summary>
        /// 获取或设置生活缴费业务场景字段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("living_expenses_fields")]
        [System.Text.Json.Serialization.JsonPropertyName("living_expenses_fields")]
        public Types.LivingExpensesField? LivingExpensesField { get; set; }

        /// <summary>
        /// 获取或设置扩展字段 1。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_fields1")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_fields1")]
        public string? ExtraField1 { get; set; }

        /// <summary>
        /// 获取或设置扩展字段 2。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_fields2")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_fields2")]
        public string? ExtraField2 { get; set; }

        /// <summary>
        /// 获取或设置扩展字段 3。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_fields3")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_fields3")]
        public string? ExtraField3 { get; set; }
    }
}
