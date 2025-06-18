using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/h5/permission/domain/applications 接口的请求。</para>
    /// </summary>
    public class CreateMerchantH5PermissionDomainApplicationRequest : WechatTenpayGlobalRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_applyment_id")]
        public string OutApplymentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domains")]
        [System.Text.Json.Serialization.JsonPropertyName("domains")]
        public IList<string> DomainList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置网站业务页面截图 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_business_page_pics")]
        [System.Text.Json.Serialization.JsonPropertyName("website_business_page_pics")]
        public IList<string>? WebsiteBusinessPagePictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置网站首页截图 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_homepage_pics")]
        [System.Text.Json.Serialization.JsonPropertyName("website_homepage_pics")]
        public IList<string>? WebsiteHomePagePictureMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置网站状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_state")]
        [System.Text.Json.Serialization.JsonPropertyName("website_state")]
        public string? WebsiteState { get; set; }

        /// <summary>
        /// 获取或设置网站 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("website_url")]
        [System.Text.Json.Serialization.JsonPropertyName("website_url")]
        public string? WebsiteUrl { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }
    }
}
