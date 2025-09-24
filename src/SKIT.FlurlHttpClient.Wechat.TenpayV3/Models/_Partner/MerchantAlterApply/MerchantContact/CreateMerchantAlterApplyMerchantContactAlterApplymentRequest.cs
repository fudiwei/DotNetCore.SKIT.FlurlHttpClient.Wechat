namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /mchalterapply/mchcontactalterapplyment 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateMerchantAlterApplyMerchantContactAlterApplymentRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置超级管理员姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_name")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string ContactName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置超级管理员证件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_type")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_type")]
                public string? IdentityType { get; set; }

                /// <summary>
                /// 获取或设置超级管理员证件号码（需使用平台公钥/证书加密）。与字段 <see cref="OpenId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_card_number")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_card_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? IdNumber { get; set; }

                /// <summary>
                /// 获取或设置超级管理员证件正面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_copy")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_copy")]
                public string? IdFrontCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置超级管理员证件背面照片媒体文件标识 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_copy_back")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_copy_back")]
                public string? IdBackCopyMediaId { get; set; }

                /// <summary>
                /// 获取或设置超级管理员证件有效期开始日期字符串（格式：yyyy-MM-dd）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_period_begin")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_period_begin")]
                public string? IdPeriodBeginDateString { get; set; }

                /// <summary>
                /// 获取或设置超级管理员证件有效期结束日期字符串（格式：yyyy-MM-dd / "长期"）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_id_doc_period_end")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_id_doc_period_end")]
                public string? IdPeriodEndDateString { get; set; }

                /// <summary>
                /// 获取或设置联系人手机号（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string MobileNumber { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置特约商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_code")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务申请编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置超级管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_info")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
        public Types.Contact Contact { get; set; } = new Types.Contact();
    }
}
