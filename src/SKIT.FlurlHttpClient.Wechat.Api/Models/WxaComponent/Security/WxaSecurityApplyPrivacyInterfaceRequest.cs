using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/security/apply_privacy_interface 接口的请求。</para>
    /// </summary>
    public class WxaSecurityApplyPrivacyInterfaceRequest : WechatApiRequest, IInferable<WxaSecurityApplyPrivacyInterfaceRequest, WxaSecurityApplyPrivacyInterfaceResponse>
    {
        /// <summary>
        /// 获取或设置申请的 API 英文名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("api_name")]
        [System.Text.Json.Serialization.JsonPropertyName("api_name")]
        public string ApiName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string ApplyReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置辅助说明图片 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_list")]
        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
        public IList<string>? PictureUrlList { get; set; }

        /// <summary>
        /// 获取或设置辅助说明视频 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_list")]
        [System.Text.Json.Serialization.JsonPropertyName("video_list")]
        public IList<string>? VideoUrlList { get; set; }

        /// <summary>
        /// 获取或设置辅助说明网站 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("url_list")]
        [System.Text.Json.Serialization.JsonPropertyName("url_list")]
        public IList<string>? UrlList { get; set; }
    }
}
