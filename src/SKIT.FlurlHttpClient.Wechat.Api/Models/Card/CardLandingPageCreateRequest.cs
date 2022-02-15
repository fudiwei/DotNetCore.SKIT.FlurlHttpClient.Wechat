using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/landingpage/create 接口的请求。</para>
    /// </summary>
    public class CardLandingPageCreateRequest : WechatApiRequest, IMapResponse<CardLandingPageCreateRequest, CardLandingPageCreateResponse>
    {
        public static class Types
        {
            public class Card
            {
                /// <summary>
                /// 获取或设置卡券模板编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_id")]
                [System.Text.Json.Serialization.JsonPropertyName("card_id")]
                public string CardId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置缩略图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_url")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_url")]
                public string ThumbnailUrl { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置 Banner 图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("banner")]
        [System.Text.Json.Serialization.JsonPropertyName("banner")]
        public string BannerUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置页面标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_title")]
        [System.Text.Json.Serialization.JsonPropertyName("page_title")]
        public string PageTitle { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置页面是否可以分享。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_share")]
        [System.Text.Json.Serialization.JsonPropertyName("can_share")]
        public bool CanShare { get; set; }

        /// <summary>
        /// 获取或设置场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene")]
        [System.Text.Json.Serialization.JsonPropertyName("scene")]
        public string Scene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_list")]
        [System.Text.Json.Serialization.JsonPropertyName("card_list")]
        public IList<Types.Card> CardList { get; set; } = new List<Types.Card>();
    }
}
