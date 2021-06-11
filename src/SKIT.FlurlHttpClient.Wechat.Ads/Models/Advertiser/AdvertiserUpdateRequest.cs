using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /advertiser/update 接口的请求。</para>
    /// </summary>
    public class AdvertiserUpdateRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置行业 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("system_industry_id")]
        [System.Text.Json.Serialization.JsonPropertyName("system_industry_id")]
        public int? IndustryId { get; set; }

        /// <summary>
        /// 获取或设置联系人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_person")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_person")]
        public string? ContactPerson { get; set; }

        /// <summary>
        /// 获取或设置联系人电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact_person_telephone")]
        [System.Text.Json.Serialization.JsonPropertyName("contact_person_telephone")]
        public string? ContactTeleNumber { get; set; }

        /// <summary>
        /// 获取或设置经营性质类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置经营内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_content")]
        [System.Text.Json.Serialization.JsonPropertyName("business_content")]
        public string? BusinessContent { get; set; }
    }
}
