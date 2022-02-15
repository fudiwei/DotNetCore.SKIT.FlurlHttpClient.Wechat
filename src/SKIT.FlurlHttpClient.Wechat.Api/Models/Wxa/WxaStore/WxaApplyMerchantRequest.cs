using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/apply_merchant 接口的请求。</para>
    /// </summary>
    public class WxaApplyMerchantRequest : WechatApiRequest, IMapResponse<WxaApplyMerchantRequest, WxaApplyMerchantResponse>
    {
        /// <summary>
        /// 获取或设置一级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first_catid")]
        [System.Text.Json.Serialization.JsonPropertyName("first_catid")]
        public int FirstCategoryId { get; set; }

        /// <summary>
        /// 获取或设置二级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second_catid")]
        [System.Text.Json.Serialization.JsonPropertyName("second_catid")]
        public int SecondCategoryId { get; set; }

        /// <summary>
        /// 获取或设置类目相关证件的媒体文件标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_list")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_list")]
        public IList<string>? QualificationMediaIdList { get; set; }

        /// <summary>
        /// 获取或设置门店小程序的昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string Nickname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店小程序的介绍。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intro")]
        [System.Text.Json.Serialization.JsonPropertyName("intro")]
        public string Introduction { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置门店小程序的头像媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headimg_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("headimg_mediaid")]
        public string HeadImageMediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营业执照图片媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("org_code")]
        [System.Text.Json.Serialization.JsonPropertyName("org_code")]
        public string? LicenseMediaId { get; set; }

        /// <summary>
        /// 获取或设置其他证明材料的媒体文件标识列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other_files")]
        [System.Text.Json.Serialization.JsonPropertyName("other_files")]
        public IList<string>? OtherFileMediaIdList { get; set; }
    }
}
