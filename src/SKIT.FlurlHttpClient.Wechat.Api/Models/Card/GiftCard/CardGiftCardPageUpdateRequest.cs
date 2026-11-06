namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/giftcard/page/update 接口的请求。</para>
    /// </summary>
    public class CardGiftCardPageUpdateRequest : WechatApiRequest, IInferable<CardGiftCardPageUpdateRequest, CardGiftCardPageUpdateResponse>
    {
        public static class Types
        {
            public class Page : CardGiftCardPageAddRequest.Types.__zz__Page
            {
                public static class Types
                {
                    public class Theme : CardGiftCardPageAddRequest.Types.Page.Types.__zz__Theme
                    {
                        public static class Types
                        {
                            public class Card : CardGiftCardPageAddRequest.Types.Page.Types.Theme.Types.Card
                            {
                            }

                            public class Picture : CardGiftCardPageAddRequest.Types.Page.Types.Theme.Types.Picture
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置礼品卡列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("item_list")]
                        public List<Types.Card>? CardList { get; set; }

                        /// <summary>
                        /// 获取或设置封面列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pic_item_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("pic_item_list")]
                        public List<Types.Picture>? PictureList { get; set; }
                    }

                    public class Category : CardGiftCardPageAddRequest.Types.Page.Types.Category
                    {
                    }

                    public class CustomCell : CardGiftCardPageAddRequest.Types.Page.Types.CustomCell
                    {
                    }
                }

                /// <summary>
                /// 获取或设置货架 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_id")]
                [System.Text.Json.Serialization.JsonPropertyName("page_id")]
                public string? PageId { get; set; }

                /// <summary>
                /// 获取或设置主题列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("theme_list")]
                [System.Text.Json.Serialization.JsonPropertyName("theme_list")]
                public List<Types.Theme>? ThemeList { get; set; }

                /// <summary>
                /// 获取或设置主题分类列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_list")]
                [System.Text.Json.Serialization.JsonPropertyName("category_list")]
                public List<Types.Category>? CategoryList { get; set; }

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
        public Types.Page? Page { get; set; }
    }
}
