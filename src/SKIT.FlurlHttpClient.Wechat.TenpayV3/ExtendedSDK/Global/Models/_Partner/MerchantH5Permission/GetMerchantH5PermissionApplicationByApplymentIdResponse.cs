namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/h5/permission/applications/{applyment_id} 接口的响应。</para>
    /// </summary>
    public class GetMerchantH5PermissionApplicationByApplymentIdResponse : WechatTenpayGlobalResponse
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
        public long ApplymentId { get; set; }

        /// <summary>
        /// 获取或设置申请类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_type")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_type")]
        public string ApplymentType { get; set; } = default!;

        /// <summary>
        /// 获取或设置申请状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_state")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_state")]
        public string ApplymentState { get; set; } = default!;

        /// <summary>
        /// 获取或设置业务描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_description")]
        [System.Text.Json.Serialization.JsonPropertyName("business_description")]
        public string? BusinessDescription { get; set; }

        /// <summary>
        /// 获取或设置交易限制类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_limit_type")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_limit_type")]
        public string TransactionLimitType { get; set; } = default!;

        /// <summary>
        /// 获取或设置域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domains")]
        [System.Text.Json.Serialization.JsonPropertyName("domains")]
        public string[] DomainList { get; set; } = default!;

        /// <summary>
        /// 获取或设置公司注册文件编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("company_register_cert")]
        [System.Text.Json.Serialization.JsonPropertyName("company_register_cert")]
        public string? CompanyRegisterCertificateNumber { get; set; }

        /// <summary>
        /// 获取或设置网站业务页面截图 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_business_page_pics")]
        [System.Text.Json.Serialization.JsonPropertyName("website_business_page_pics")]
        public string[]? WebsiteBusinessPagePictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置网站首页截图 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_homepage_pics")]
        [System.Text.Json.Serialization.JsonPropertyName("website_homepage_pics")]
        public string[]? WebsiteHomePagePictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置网站状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_state")]
        [System.Text.Json.Serialization.JsonPropertyName("website_state")]
        public string WebsiteState { get; set; } = default!;

        /// <summary>
        /// 获取或设置网站 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_url")]
        [System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string WebsiteUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置审核拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_reject_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_reject_detail")]
        public string? AuditRejectReason { get; set; }
    }
}
