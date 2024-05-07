using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchants 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class AddSubMerchantRequest : WechatTenpayGlobalRequest
    {
        public static class Types
        {
            public class Contact
            {
                /// <summary>
                /// 获取或设置联系人姓名（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1)]
                public string ContactName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系电话号码（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1)]
                public string MobileNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置联系邮箱（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS1)]
                public string Email { get; set; } = string.Empty;
            }

            public class Business
            {
                /// <summary>
                /// 获取或设置业务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_type")]
                [System.Text.Json.Serialization.JsonPropertyName("business_type")]
                public string BusinessType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商户行业编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mcc")]
                [System.Text.Json.Serialization.JsonPropertyName("mcc")]
                public string? MerchantCategoryCode { get; set; }

                /// <summary>
                /// 获取或设置 App 下载链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_download")]
                [System.Text.Json.Serialization.JsonPropertyName("app_download")]
                public string? AppDownloadUrl { get; set; }

                /// <summary>
                /// 获取或设置业务网站链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("website")]
                [System.Text.Json.Serialization.JsonPropertyName("website")]
                public string? WebsiteUrl { get; set; }

                /// <summary>
                /// 获取或设置公众号 AppId。</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("office_account")]
                [System.Text.Json.Serialization.JsonPropertyName("office_account")]
                public string? OfficeAccountAppId { get; set; }

                /// <summary>
                /// 获取或设置小程序 AppId。</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mini_program")]
                [System.Text.Json.Serialization.JsonPropertyName("mini_program")]
                public string? MiniProgramAppId { get; set; }

                /// <summary>
                /// 获取或设置门店地址。</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_address")]
                [System.Text.Json.Serialization.JsonPropertyName("store_address")]
                public string? StoreAddress { get; set; }

                /// <summary>
                /// 获取或设置门店照片 MediaId 列表。</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_photos")]
                [System.Text.Json.Serialization.JsonPropertyName("store_photos")]
                public IList<string>? StorePhotoMediaIdList { get; set; }
            }

            public class Director
            {
                /// <summary>
                /// 获取或设置董事姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置董事证件号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("number")]
                [System.Text.Json.Serialization.JsonPropertyName("number")]
                public string? IdNumber { get; set; }
            }

            public class Principal
            {
                /// <summary>
                /// 获取或设置负责人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置负责人证件号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("number")]
                [System.Text.Json.Serialization.JsonPropertyName("number")]
                public string? IdNumber { get; set; }
            }

            public class H5PaymentApplyment
            {
                /// <summary>
                /// 获取或设置网站 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("website_url")]
                [System.Text.Json.Serialization.JsonPropertyName("website_url")]
                public string? WebsiteUrl { get; set; }

                /// <summary>
                /// 获取或设置域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domains")]
                [System.Text.Json.Serialization.JsonPropertyName("domains")]
                public IList<string>? DomainList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务请求幂等值。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string IdempotencyKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置机构商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置机构微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置商户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string MerchantName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shortname")]
        [System.Text.Json.Serialization.JsonPropertyName("shortname")]
        public string MerchantShortName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册国家或地区代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_country_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("office_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("office_phone")]
        public string OfficePhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置联系人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact")]
        [System.Text.Json.Serialization.JsonPropertyName("contact")]
        public Types.Contact Contact { get; set; } = new Types.Contact();

        /// <summary>
        /// 获取或设置商业类目编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_category")]
        [System.Text.Json.Serialization.JsonPropertyName("business_category")]
        public int BusinessCategoryCode { get; set; }

        /// <summary>
        /// 获取或设置公司注册文件编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_certificate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_certificate_number")]
        public string RegistrationCertificateNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司注册文件过期时间字符串（格式：yyyy-MM-dd / PERMANENT）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_certificate_date")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_certificate_date")]
        public string RegistrationCertificateDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司注册文件照片 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_certificate_copy")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_certificate_copy")]
        public string? RegistrationCertificateCopyMediaId { get; set; }

        /// <summary>
        /// 获取或设置子商户银行结算账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_bank_number")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_bank_number")]
        public string SettlementBankNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business")]
        [System.Text.Json.Serialization.JsonPropertyName("business")]
        public Types.Business Business { get; set; } = new Types.Business();

        /// <summary>
        /// 获取或设置董事信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("director")]
        [System.Text.Json.Serialization.JsonPropertyName("director")]
        public Types.Director? Director { get; set; }

        /// <summary>
        /// 获取或设置负责人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("principal")]
        [System.Text.Json.Serialization.JsonPropertyName("principal")]
        public Types.Principal? Principal { get; set; }

        /// <summary>
        /// 获取或设置是否申请开通 H5 支付权限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_h5_payment")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_h5_payment")]
        public bool? IsApplyH5Payment { get; set; }

        /// <summary>
        /// 获取或设置 H5 支付权限申请信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("h5_payment_apply_info")]
        [System.Text.Json.Serialization.JsonPropertyName("h5_payment_apply_info")]
        public Types.H5PaymentApplyment? H5PaymentApplyment { get; set; }
    }
}
