namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/order/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierOrderGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CommssionOrder
            {
                public static class Types
                {
                    public class OrderDetail
                    {
                        public static class Types
                        {
                            public class ShopInfo
                            {
                                /// <summary>
                                /// 获取或设置小店 AppId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("appid")]
                                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                public string? ShopAppId { get; set; }

                                /// <summary>
                                /// 获取或设置小店名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shop_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
                                public string? ShopName { get; set; }
                            }

                            public class ProductInfo
                            {
                                /// <summary>
                                /// 获取或设置商品 ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public long ProductId { get; set; }

                                /// <summary>
                                /// 获取或设置商品缩略图 URL。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("thumb_img")]
                                [System.Text.Json.Serialization.JsonPropertyName("thumb_img")]
                                public string? ThumbnailUrl { get; set; }

                                /// <summary>
                                /// 获取或设置商品标题。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("title")]
                                [System.Text.Json.Serialization.JsonPropertyName("title")]
                                public string? Title { get; set; }

                                /// <summary>
                                /// 获取或设置可佣金金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_payment")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_payment")]
                                public int ActualPayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置商品数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_cnt")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_cnt")]
                                public int ProductCount { get; set; }
                            }

                            public class OrderInfo
                            {
                                /// <summary>
                                /// 获取或设置订单状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("order_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                                public int Status { get; set; }

                                /// <summary>
                                /// 获取或设置订单支付时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                                public long? PayTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置订单创建时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("create_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                                public long CreateTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置订单更新时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("update_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                                public long UpdateTimestamp { get; set; }
                            }

                            public class CommissionInfo
                            {
                                public static class Types
                                {
                                    public class FinderInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置达人昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                        public string? Nickname { get; set; }

                                        /// <summary>
                                        /// 获取或设置达人头像 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("head_img_url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                                        public string? HeadImageUrl { get; set; }

                                        /// <summary>
                                        /// 获取或设置视频号 OpenFinderId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("openfinderid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("openfinderid")]
                                        public string? OpenFinderId { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金费率（单位：万分数）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ratio")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                                        public int CommissionRatio { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        public int CommissionAmount { get; set; }
                                    }

                                    public class SharerInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置推客 AppId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sharer_appid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
                                        public string? SharerAppId { get; set; }

                                        /// <summary>
                                        /// 获取或设置推客昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                        public string? Nickname { get; set; }

                                        /// <summary>
                                        /// 获取或设置推客头像 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("head_img_url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                                        public string? HeadImageUrl { get; set; }

                                        /// <summary>
                                        /// 获取或设置推客 OpenSharerId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("opensharerid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("opensharerid")]
                                        public string? OpenSharerId { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        public int Amount { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金率（单位：万分数）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ratio")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                                        public int Ratio { get; set; }
                                    }

                                    public class TalentInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置达人平台 AppId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("talent_appid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
                                        public string? TalentAppId { get; set; }

                                        /// <summary>
                                        /// 获取或设置达人平台昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                        public string? Nickname { get; set; }

                                        /// <summary>
                                        /// 获取或设置达人平台头像 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("head_img_url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                                        public string? HeadImageUrl { get; set; }

                                        /// <summary>
                                        /// 获取或设置带货达人 OpenTalentId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("opentalentid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("opentalentid")]
                                        public string? OpenTalentId { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        public int Amount { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金率（单位：万分数）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ratio")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                                        public int Ratio { get; set; }
                                    }

                                    public class AgencyInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置机构 AppId。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("appid")]
                                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                        public string? AgencyAppId { get; set; }

                                        /// <summary>
                                        /// 获取或设置帮卖机构昵称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("nickname")]
                                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                        public string? Nickname { get; set; }

                                        /// <summary>
                                        /// 获取或设置帮卖机构头像 URL。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("head_img_url")]
                                        [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                                        public string? HeadImageUrl { get; set; }

                                        /// <summary>
                                        /// 获取或设置结算时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("profit_sharding_suc_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("profit_sharding_suc_time")]
                                        public long ProfitShardingSuccessTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                                        public int Amount { get; set; }

                                        /// <summary>
                                        /// 获取或设置佣金率（单位：万分数）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("ratio")]
                                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                                        public int Ratio { get; set; }
                                    }

                                    public class PromotionInfo
                                    {
                                        public static class Types
                                        {
                                            public class FinderInfo
                                            {
                                                /// <summary>
                                                /// 获取或设置视频号 ID。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("finder_id")]
                                                [System.Text.Json.Serialization.JsonPropertyName("finder_id")]
                                                public string? FinderId { get; set; }

                                                /// <summary>
                                                /// 获取或设置视频号昵称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("nickname")]
                                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                                public string? Nickname { get; set; }

                                                /// <summary>
                                                /// 获取或设置视频号 OpenFinderId。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("openfinderid")]
                                                [System.Text.Json.Serialization.JsonPropertyName("openfinderid")]
                                                public string? OpenFinderId { get; set; }
                                            }

                                            public class TalentInfo
                                            {
                                                /// <summary>
                                                /// 获取或设置达人平台 AppId。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("talent_appid")]
                                                [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
                                                public string? TalentAppId { get; set; }

                                                /// <summary>
                                                /// 获取或设置达人平台昵称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("nickname")]
                                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                                public string? Nickname { get; set; }

                                                /// <summary>
                                                /// 获取或设置带货达人 OpenTalentId。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("opentalentid")]
                                                [System.Text.Json.Serialization.JsonPropertyName("opentalentid")]
                                                public string? OpenTalentId { get; set; }
                                            }

                                            public class MpInfo
                                            {
                                                /// <summary>
                                                /// 获取或设置公众号 AppId。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("appid")]
                                                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                                                public string? MpAppId { get; set; }

                                                /// <summary>
                                                /// 获取或设置公众号昵称。
                                                /// </summary>
                                                [Newtonsoft.Json.JsonProperty("nickname")]
                                                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                                                public string? Nickname { get; set; }
                                            }
                                        }

                                        /// <summary>
                                        /// 获取或设置推广类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("channel_type")]
                                        [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
                                        public int ChannelType { get; set; }

                                        /// <summary>
                                        /// 获取或设置视频号类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("finder_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("finder_info")]
                                        public Types.FinderInfo? FinderInfo { get; set; }

                                        /// <summary>
                                        /// 获取或设置带货达人类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("talent_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("talent_info")]
                                        public Types.TalentInfo? TalentInfo { get; set; }

                                        /// <summary>
                                        /// 获取或设置公众号类型。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("mp_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("mp_info")]
                                        public Types.MpInfo? MpInfo { get; set; }

                                        /// <summary>
                                        /// 获取或设置机构自定义关联参数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("custom_token")]
                                        [System.Text.Json.Serialization.JsonPropertyName("custom_token")]
                                        public string? CustomToken { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置达人信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("finder_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("finder_info")]
                                public Types.FinderInfo? FinderInfo { get; set; }

                                /// <summary>
                                /// 获取或设置服务费率（单位：万分数）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_ratio")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_ratio")]
                                public int ServiceRatio { get; set; }

                                /// <summary>
                                /// 获取或设置服务费用（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_amount")]
                                public int ServiceAmount { get; set; }

                                /// <summary>
                                /// 获取或设置结算时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("profit_sharding_suc_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("profit_sharding_suc_time")]
                                public long ProfitShardingSuccessTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置带货渠道。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promotion_channel")]
                                [System.Text.Json.Serialization.JsonPropertyName("promotion_channel")]
                                public int PromotionChannel { get; set; }

                                /// <summary>
                                /// 获取或设置推客信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sharer_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("sharer_info")]
                                public Types.SharerInfo? SharerInfo { get; set; }

                                /// <summary>
                                /// 获取或设置达人平台信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("talent_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("talent_info")]
                                public Types.TalentInfo? TalentInfo { get; set; }

                                /// <summary>
                                /// 获取或设置推广信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promotion_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("promotion_info")]
                                public Types.PromotionInfo? PromotionInfo { get; set; }

                                /// <summary>
                                /// 获取或设置帮卖机构信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sub_agency_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("sub_agency_info")]
                                public Types.AgencyInfo? SubAgencyInfo { get; set; }

                                /// <summary>
                                /// 获取或设置推客机构信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promoter_agency_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("promoter_agency_info")]
                                public Types.AgencyInfo? PromoterAgencyInfo { get; set; }

                                /// <summary>
                                /// 获取或设置供货机构信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("head_agency_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("head_agency_info")]
                                public Types.AgencyInfo? HeadAgencyInfo { get; set; }

                                /// <summary>
                                /// 获取或设置联盟技术服务费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_amount")]
                                public int PlatformAmount { get; set; }

                                /// <summary>
                                /// 获取或设置联盟技术服务费计算状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_commission_status")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_commission_status")]
                                public int PlatformCommissionStatus { get; set; }

                                /// <summary>
                                /// 获取或设置服务费总额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("service_total_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("service_total_amount")]
                                public int ServiceTotalAmount { get; set; }
                            }

                            public class BuyerInfo
                            {
                                /// <summary>
                                /// 获取或设置买家的 OpenId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("open_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                                public string? OpenId { get; set; }

                                /// <summary>
                                /// 获取或设置买家的 UnionId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("union_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                                public string? UnionId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置小店商家信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_info")]
                        public Types.ShopInfo? ShopInfo { get; set; }

                        /// <summary>
                        /// 获取或设置商品详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                        public Types.ProductInfo? ProductInfo { get; set; }

                        /// <summary>
                        /// 获取或设置订单信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
                        public Types.OrderInfo? OrderInfo { get; set; }

                        /// <summary>
                        /// 获取或设置佣金信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                        public Types.CommissionInfo? CommissionInfo { get; set; }

                        /// <summary>
                        /// 获取或设置买家信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_info")]
                        public Types.BuyerInfo? BuyerInfo { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置佣金单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("order_detail")]
                public Types.OrderDetail? OrderDetail { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置佣金单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commssion_order")]
        [System.Text.Json.Serialization.JsonPropertyName("commssion_order")]
        public Types.CommssionOrder? CommssionOrder { get; set; }
    }
}
