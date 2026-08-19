using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promoter/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeaguePromoterGetResponse : WechatApiResponse
    {
        public static class Types
        {
            [Obsolete("相关接口或字段于 2026-03-30 下线。")]
            public class Promoter
            {
                /// <summary>
                /// 获取或设置视频号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finder_id")]
                [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                public string FinderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置合作状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置邀请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invite_time")]
                [System.Text.Json.Serialization.JsonPropertyName("invite_time")]
                public long InviteTimestamp { get; set; }

                /// <summary>
                /// 获取或设置累计合作商品数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_product_number")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_product_number")]
                public int SaleProductCount { get; set; }

                /// <summary>
                /// 获取或设置合作动销 GMV。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_gmv")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_gmv")]
                public int SaleGMV { get; set; }
            }

            public class Talent
            {
                public static class Types
                {
                    public class BaseInfo
                    {
                        /// <summary>
                        /// 获取或设置带货达人 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
                        public string TalentAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置带货达人昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置带货达人头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_img")]
                        public string HeadImageUrl { get; set; } = default!;
                    }

                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置累计销售额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_sale_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_sale_gmv")]
                        public int TotalSaleGMV { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 日销售额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_gmv_30d")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_gmv_30d")]
                        public int SaleGMVIn30Days { get; set; }

                        /// <summary>
                        /// 获取或设置累计订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_order_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_order_num")]
                        public int TotalOrderCount { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 日成交订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_num_30d")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_num_30d")]
                        public int OrderCouuntIn30Days { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 日成交商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_product_num_30d")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_product_num_30d")]
                        public int SaleProductCountIn30Days { get; set; }

                        /// <summary>
                        /// 获取或设置橱窗商品数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("window_product_num")]
                        [System.Text.Json.Serialization.JsonPropertyName("window_product_num")]
                        public int WindowProductCount { get; set; }
                    }

                    public class Feature
                    {
                        /// <summary>
                        /// 获取或设置等级。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("level")]
                        [System.Text.Json.Serialization.JsonPropertyName("level")]
                        public int Level { get; set; }

                        /// <summary>
                        /// 获取或设置是否被拉黑。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_blacklisted")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_blacklisted")]
                        public bool IsBlackListed { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置基础信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_talent_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_talent_info")]
                public Types.BaseInfo BaseInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置数据信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Data Data { get; set; } = default!;

                /// <summary>
                /// 获取或设置特征信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("feature_info")]
                [System.Text.Json.Serialization.JsonPropertyName("feature_info")]
                public Types.Feature Feature { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置达人信息。
        /// </summary>
        [Obsolete("相关接口或字段于 2026-03-30 下线。")]
        [Newtonsoft.Json.JsonProperty("promoter")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter")]
        public Types.Promoter Promoter { get; set; } = default!;

        /// <summary>
        /// 获取或设置带货达人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("talent")]
        [System.Text.Json.Serialization.JsonPropertyName("talent")]
        public Types.Talent Talent { get; set; } = default!;
    }
}
