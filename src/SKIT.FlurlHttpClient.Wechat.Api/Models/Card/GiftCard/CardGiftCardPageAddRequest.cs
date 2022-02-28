using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/page/add 接口的请求。</para>
    /// </summary>
    public class CardGiftCardPageAddRequest : WechatApiRequest, IMapResponse<CardGiftCardPageAddRequest, CardGiftCardPageAddResponse>
    {
        public static class Types
        {
            public class Page
            {
                public static class Types
                {
                    public class Theme
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
                                /// 获取或设置商品名。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string? Title { get; set; }

                                /// <summary>
                                /// 获取或设置商品缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pic_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("pic_url")]
                                public string? PictureUrl { get; set; }

                                /// <summary>
                                /// 获取或设置商品简介。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("desc")]
                                [System.Text.Json.Serialization.JsonPropertyName("desc")]
                                public string? Description { get; set; }
                            }

                            public class Picture
                            {
                                /// <summary>
                                /// 获取或设置卡面图片 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("background_pic_url")]
                                [System.Text.Json.Serialization.JsonPropertyName("background_pic_url")]
                                public string BackgroundPictureUrl { get; set; } = string.Empty;

                                /// <summary>
                                /// 获取或设置自定义卡面标识 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("outer_img_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("outer_img_id")]
                                public string? OuterImageUrl { get; set; }

                                /// <summary>
                                /// 获取或设置该卡面对应的默认祝福语。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("default_gifting_msg")]
                                [System.Text.Json.Serialization.JsonPropertyName("default_gifting_msg")]
                                public string? DefaultGiftingMessage { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置主题封面图片 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("theme_pic_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("theme_pic_url")]
                        public string ThemePictureUrl { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置主题名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置主题颜色（格式：#RRGGBB）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title_color")]
                        [System.Text.Json.Serialization.JsonPropertyName("title_color")]
                        public string TitleColor { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置礼品卡列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                        public IList<Types.Card> CardList { get; set; } = new List<Types.Card>();

                        /// <summary>
                        /// 获取或设置封面列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_item_list")]
                        public IList<Types.Picture> PictureList { get; set; } = new List<Types.Picture>();

                        /// <summary>
                        /// 获取或设置主题分类标号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_index")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_index")]
                        public int CategoryIndex { get; set; }

                        /// <summary>
                        /// 获取或设置该主题购买页是否突出商品名显示。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("show_sku_title_first")]
                        [System.Text.Json.Serialization.JsonPropertyName("show_sku_title_first")]
                        public bool? IsShowSKUTitleFirst { get; set; }

                        /// <summary>
                        /// 获取或设置是否将当前主题设置为 Banner 主题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_banner")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_banner")]
                        public bool? IsBanner { get; set; }
                    }

                    public class Category
                    {
                        /// <summary>
                        /// 获取或设置主题分类名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;
                    }

                    public class CustomCell
                    {
                        /// <summary>
                        /// 获取或设置入口名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置入口跳转链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("url")]
                        [System.Text.Json.Serialization.JsonPropertyName("url")]
                        public string Url { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置 Banner 图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banner_pic_url")]
                [System.Text.Json.Serialization.JsonPropertyName("banner_pic_url")]
                public string BannerUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置页面标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_title")]
                [System.Text.Json.Serialization.JsonPropertyName("page_title")]
                public string PageTitle { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否支持一次购买多张。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("support_multi")]
                [System.Text.Json.Serialization.JsonPropertyName("support_multi")]
                public bool? IsSupportMultiple { get; set; }

                /// <summary>
                /// 获取或设置是否支持买给自己。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("support_buy_for_self")]
                [System.Text.Json.Serialization.JsonPropertyName("support_buy_for_self")]
                public bool? IsSupportBuyForSelf { get; set; }

                /// <summary>
                /// 获取或设置主题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("theme_list")]
                [System.Text.Json.Serialization.JsonPropertyName("theme_list")]
                public IList<Types.Theme>? ThemeList { get; set; }

                /// <summary>
                /// 获取或设置主题分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_list")]
                [System.Text.Json.Serialization.JsonPropertyName("category_list")]
                public IList<Types.Category>? CategoryList { get; set; }

                /// <summary>
                /// 获取或设置商家地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string Address { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商家服务电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
                public string ServicePhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商家使用说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_description")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_description")]
                public string BusinessDescription { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置是否支持开发票。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("need_receipt")]
                [System.Text.Json.Serialization.JsonPropertyName("need_receipt")]
                public bool? IsSupportReceipt { get; set; }

                /// <summary>
                /// 获取或设置自定义服务入口 1 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cell_1")]
                [System.Text.Json.Serialization.JsonPropertyName("cell_1")]
                public Types.CustomCell? CustomCell1 { get; set; }

                /// <summary>
                /// 获取或设置自定义服务入口 2 信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cell_2")]
                [System.Text.Json.Serialization.JsonPropertyName("cell_2")]
                public Types.CustomCell? CustomCell2 { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置货架信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public Types.Page Page { get; set; } = new Types.Page();
    }
}
