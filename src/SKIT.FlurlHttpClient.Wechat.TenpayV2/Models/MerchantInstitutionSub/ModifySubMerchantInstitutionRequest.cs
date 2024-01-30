using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/mch/modifyInstitutionsub 接口的请求。</para>
    /// </summary>
    public class ModifySubMerchantInstitutionRequest : WechatTenpaySignableRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mch_id")]
        public string SubMerhantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置子商户全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_shortname")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
        public string MerchantShortName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务类目编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_category")]
        [System.Text.Json.Serialization.JsonPropertyName("business_category")]
        public int BusinessCategoryCode { get; set; }

        /// <summary>
        /// 获取或设置商户类别编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mcc")]
        [System.Text.Json.Serialization.JsonPropertyName("mcc")]
        public string MerchantCategoryCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册国家或地区代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_country_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_country_code")]
        public string CountryCode { get; set; } = string.Empty;

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
        public string? RegistrationCertificatePictureMediaId { get; set; }

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string BusinessType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 App 下载链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_download")]
        [System.Text.Json.Serialization.JsonPropertyName("app_download")]
        public string? AppDownloadUrl { get; set; }

        /// <summary>
        /// 获取或设置业务网站地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_website")]
        [System.Text.Json.Serialization.JsonPropertyName("business_website")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// 获取或设置公众号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("office_account")]
        [System.Text.Json.Serialization.JsonPropertyName("office_account")]
        public string? OfficeAccountAppId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mini_program")]
        [System.Text.Json.Serialization.JsonPropertyName("mini_program")]
        public string? MiniProgramAppId { get; set; }

        /// <summary>
        /// 获取或设置门店地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_address")]
        [System.Text.Json.Serialization.JsonPropertyName("store_address")]
        public string? StoreAddress { get; set; }

        /// <summary>
        /// 获取或设置门店照片 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_photos")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("store_photos")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedObjectInJsonFormatConverter))]
        public IList<string>? StorePhotoMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置董事姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("director_name")]
        [System.Text.Json.Serialization.JsonPropertyName("director_name")]
        public string? DirectorName { get; set; }

        /// <summary>
        /// 获取或设置董事证件号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("director_id_number")]
        [System.Text.Json.Serialization.JsonPropertyName("director_id_number")]
        public string? DirectorIdNumber { get; set; }

        /// <summary>
        /// 获取或设置负责人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("principal_name")]
        [System.Text.Json.Serialization.JsonPropertyName("principal_name")]
        public string? PrincipalName { get; set; }

        /// <summary>
        /// 获取或设置负责人证件号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("principal_id_number")]
        [System.Text.Json.Serialization.JsonPropertyName("principal_id_number")]
        public string? PrincipalIdNumber { get; set; }

        /// <summary>
        /// 获取或设置公司电话。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("office_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("office_phone")]
        public string? OfficePhoneNumber { get; set; }

        /// <summary>
        /// 获取或设置联系人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_name")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
        public string? ContactName { get; set; }

        /// <summary>
        /// 获取或设置联系人电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_phone")]
        public string? ContactPhotoNumber { get; set; }

        /// <summary>
        /// 获取或设置联系人邮箱。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_email")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_email")]
        public string? ContactEmail { get; set; }

        /// <summary>
        /// 获取或设置子商户结算银行账户	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_bank_number")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_bank_number")]
        public string? SettlementBankNumber { get; set; }
    }
}
