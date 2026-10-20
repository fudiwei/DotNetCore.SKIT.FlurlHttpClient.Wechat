namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /med-ins/orders 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateMedicalInsuranceOrderRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Payer
            {
                /// <summary>
                /// 获取或设置真实姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_type")]
                [System.Text.Json.Serialization.JsonPropertyName("card_type")]
                public string CardType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置个人身份 ID 摘要（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_digest")]
                [System.Text.Json.Serialization.JsonPropertyName("id_digest")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string IdDigest { get; set; } = string.Empty;
            }

            public class Relative : Payer
            {
            }

            public class CashAddDetail
            {
                /// <summary>
                /// 获取或设置现金补充类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_add_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_add_type")]
                public string CashAddType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置现金补充金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_add_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_add_fee")]
                public int CashAddFee { get; set; }
            }

            public class CashReduceDetail
            {
                /// <summary>
                /// 获取或设置现金减免类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_reduce_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_reduce_type")]
                public string CashReduceType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置现金减免金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cash_reduce_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("cash_reduce_fee")]
                public int CashReduceFee { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置混合支付类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mix_pay_type")]
        [System.Text.Json.Serialization.JsonPropertyName("mix_pay_type")]
        public string MixPayType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置订单类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_type")]
        [System.Text.Json.Serialization.JsonPropertyName("order_type")]
        public string OrderType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置用户在子商户下的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

        /// <summary>
        /// 获取或设置支付人身份信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer Payer { get; set; } = new Types.Payer();

        /// <summary>
        /// 获取或设置是否代亲属支付。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_for_relatives")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_for_relatives")]
        public bool? IsPayForRelatives { get; set; }

        /// <summary>
        /// 获取或设置亲属身份信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relative")]
        [System.Text.Json.Serialization.JsonPropertyName("relative")]
        public Types.Relative? Relative { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置医疗机构订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serial_no")]
        [System.Text.Json.Serialization.JsonPropertyName("serial_no")]
        public string SerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置医保局返回的支付单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_order_id")]
        public string? PayOrderId { get; set; }

        /// <summary>
        /// 获取或设置医保局返回的支付授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_auth_no")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_auth_no")]
        public string? PayAuthNumber { get; set; }

        /// <summary>
        /// 获取或设置用户定位信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geo_location")]
        [System.Text.Json.Serialization.JsonPropertyName("geo_location")]
        public string? GeoLocation { get; set; }

        /// <summary>
        /// 获取或设置城市 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_id")]
        [System.Text.Json.Serialization.JsonPropertyName("city_id")]
        public string CityId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置医疗机构名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_inst_name")]
        [System.Text.Json.Serialization.JsonPropertyName("med_inst_name")]
        public string MedicalInstitutionName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置医疗机构编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_inst_no")]
        [System.Text.Json.Serialization.JsonPropertyName("med_inst_no")]
        public string MedicalInstitutionNo { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置医保下单时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_ins_order_create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("med_ins_order_create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? MedicalInsuranceOrderCreateTime { get; set; }

        /// <summary>
        /// 获取或设置总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("total_fee")]
        public int TotalFee { get; set; }

        /// <summary>
        /// 获取或设置医保局结算后的医保统筹支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_ins_gov_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_ins_gov_fee")]
        public int? MedicalInsuranceGovernerFee { get; set; }

        /// <summary>
        /// 获取或设置医保局结算后的医保个账支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_ins_self_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_ins_self_fee")]
        public int? MedicalInsuranceSelfFee { get; set; }

        /// <summary>
        /// 获取或设置医保局结算后的医保其他支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_ins_other_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_ins_other_fee")]
        public int? MedicalInsuranceOtherFee { get; set; }

        /// <summary>
        /// 获取或设置医保局结算后的需要自费的金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_ins_cash_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("med_ins_cash_fee")]
        public int? MedicalInsuranceCashFee { get; set; }

        /// <summary>
        /// 获取或设置实际需要用户微信支付的金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wechat_pay_cash_fee")]
        [System.Text.Json.Serialization.JsonPropertyName("wechat_pay_cash_fee")]
        public int? WechatpayCashFee { get; set; }

        /// <summary>
        /// 获取或设置现金补充列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_add_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_add_detail")]
        public IList<Types.CashAddDetail>? CashAddDetailList { get; set; }

        /// <summary>
        /// 获取或设置现金减免列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cash_reduce_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("cash_reduce_detail")]
        public IList<Types.CashReduceDetail>? CashReduceDetailList { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string? CallbackUrl { get; set; }

        /// <summary>
        /// 获取或设置自费预下单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prepay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("prepay_id")]
        public string? PrepayId { get; set; }

        /// <summary>
        /// 获取或设置医疗机构透传给医保的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("passthrough_request_content")]
        [System.Text.Json.Serialization.JsonPropertyName("passthrough_request_content")]
        public string? PassthroughRequestContent { get; set; }

        /// <summary>
        /// 获取或设置扩展字段。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extends")]
        [System.Text.Json.Serialization.JsonPropertyName("extends")]
        public string? Extends { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置渠道号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_no")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_no")]
        public string? ChannelNumber { get; set; }

        /// <summary>
        /// 获取或设置是否到医保局测试环境下单。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("med_ins_test_env")]
        [System.Text.Json.Serialization.JsonPropertyName("med_ins_test_env")]
        public bool? IsMedicalInsuranceTestEnvironment { get; set; }
    }
}
