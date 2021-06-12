using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /adcreatives/add 接口的请求。</para>
    /// </summary>
    public class AdCreativesAddRequest : WechatAdsRequest
    {
        public static class Types
        {
            public class Element
            {
                /// <summary>
                /// 获取或设置广告文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置广告描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置图片 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image")]
                [System.Text.Json.Serialization.JsonPropertyName("image")]
                public string? ImageId { get; set; }

                /// <summary>
                /// 获取或设置图片 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_list")]
                [System.Text.Json.Serialization.JsonPropertyName("image_list")]
                public IList<string>? ImageIdList { get; set; }

                /// <summary>
                /// 获取或设置链接名称类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("link_name_type")]
                [System.Text.Json.Serialization.JsonPropertyName("link_name_type")]
                public string? LinkNameType { get; set; }
            }

            public class Share
            {
                /// <summary>
                /// 获取或设置分享标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_title")]
                [System.Text.Json.Serialization.JsonPropertyName("share_title")]
                public string Title { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分享描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_description")]
                [System.Text.Json.Serialization.JsonPropertyName("share_description")]
                public string Description { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置推广计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("campaign_id")]
        [System.Text.Json.Serialization.JsonPropertyName("campaign_id")]
        public long CampaignId { get; set; }

        /// <summary>
        /// 获取或设置广告创意名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcreative_name")]
        [System.Text.Json.Serialization.JsonPropertyName("adcreative_name")]
        public string AdCreativeName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告创意规格 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcreative_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("adcreative_template_id")]
        public int AdCreativeTemplateId { get; set; }

        /// <summary>
        /// 获取或设置广告创意元素信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("adcreative_elements")]
        [System.Text.Json.Serialization.JsonPropertyName("adcreative_elements")]
        public Types.Element AdCreativeElement { get; set; } = new Types.Element();

        /// <summary>
        /// 获取或设置投放站点列表。
        /// <para>默认值：["SITE_SET_WECHAT"]</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("site_set")]
        [System.Text.Json.Serialization.JsonPropertyName("site_set")]
        public IList<string> SiteList { get; set; } = new List<string>() { "SITE_SET_WECHAT" };

        /// <summary>
        /// 获取或设置目标 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("destination_url")]
        [System.Text.Json.Serialization.JsonPropertyName("destination_url")]
        public string DestinationUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标的物类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_type")]
        public string ProductType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置标的物 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_refs_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_refs_id")]
        public string? ProductRefId { get; set; }

        /// <summary>
        /// 获取或设置分享信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_info")]
        [System.Text.Json.Serialization.JsonPropertyName("share_info")]
        public Types.Share? Share { get; set; }
    }
}
