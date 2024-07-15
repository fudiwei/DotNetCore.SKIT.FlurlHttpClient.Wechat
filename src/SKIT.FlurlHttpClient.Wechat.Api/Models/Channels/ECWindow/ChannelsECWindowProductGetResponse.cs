namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/window/product/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECWindowProductGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class MiniProgramPagePath
                    {
                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置半屏页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("half_page_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("half_page_path")]
                        public string? HalfPagePath { get; set; }

                        /// <summary>
                        /// 获取或设置全屏页面路径。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("full_page_path")]
                        [System.Text.Json.Serialization.JsonPropertyName("full_page_path")]
                        public string? FullPagePath { get; set; }
                    }

                    public class BannedDetail
                    {
                        /// <summary>
                        /// 获取或设置仅售原因 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ReasonId { get; set; }

                        /// <summary>
                        /// 获取或设置需要申请的类目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_apply_category_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_apply_category_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long? RequiredCategoryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置需要申请的类目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("need_apply_category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("need_apply_category_name")]
                        public string? RequiredCategoryName { get; set; }
                    }

                    public class Branch
                    {
                        /// <summary>
                        /// 获取或设置分店 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("branch_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("branch_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long BranchId { get; set; }

                        /// <summary>
                        /// 获取或设置分店名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("branch_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("branch_name")]
                        public string BranchName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置分店状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("branch_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("branch_status")]
                        public int BranchStatus { get; set; }
                    }

                    public class LimitedDiscount
                    {
                        /// <summary>
                        /// 获取或设置是否有生效中的抢购活动。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_effect")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_effect")]
                        public bool IsEffective { get; set; }

                        /// <summary>
                        /// 获取或设置抢购价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("discount_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("discount_price")]
                        public int DiscountPrice { get; set; }

                        /// <summary>
                        /// 获取或设置剩余库存。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock")]
                        public int Stock { get; set; }

                        /// <summary>
                        /// 获取或设置活动结束时间毫秒级时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time_ms")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time_ms")]
                        public long EndTimeMilliseconds { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品来源店铺的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
                public string? OutProductId { get; set; }

                /// <summary>
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品头图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("img_url")]
                public string ImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品三级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置市场价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("market_price")]
                [System.Text.Json.Serialization.JsonPropertyName("market_price")]
                public int MarketPrice { get; set; }

                /// <summary>
                /// 获取或设置销售价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("selling_price")]
                [System.Text.Json.Serialization.JsonPropertyName("selling_price")]
                public int SellingPrice { get; set; }

                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock")]
                [System.Text.Json.Serialization.JsonPropertyName("stock")]
                public int Stock { get; set; }

                /// <summary>
                /// 获取或设置销量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sales")]
                [System.Text.Json.Serialization.JsonPropertyName("sales")]
                public int Sales { get; set; }

                /// <summary>
                /// 获取或设置商品详情页小程序信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("page_path")]
                [System.Text.Json.Serialization.JsonPropertyName("page_path")]
                public Types.MiniProgramPagePath? MiniProgramPagePath { get; set; }

                /// <summary>
                /// 获取或设置电商平台 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_id")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_id")]
                public long? PlatformId { get; set; }

                /// <summary>
                /// 获取或设置电商平台名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_name")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_name")]
                public string? PlatformName { get; set; }

                /// <summary>
                /// 获取或设置是否需要在个人橱窗页隐藏。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_hide_for_window")]
                [System.Text.Json.Serialization.JsonPropertyName("is_hide_for_window")]
                public bool IsHideForWindow { get; set; }

                /// <summary>
                /// 获取或设置是否禁止售卖。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banned")]
                [System.Text.Json.Serialization.JsonPropertyName("banned")]
                public bool IsBanned { get; set; }

                /// <summary>
                /// 获取或设置禁售详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("banned_details")]
                [System.Text.Json.Serialization.JsonPropertyName("banned_details")]
                public Types.BannedDetail? BannedDetail { get; set; }

                /// <summary>
                /// 获取或设置分店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("branch_info")]
                [System.Text.Json.Serialization.JsonPropertyName("branch_info")]
                public Types.Branch? Branch { get; set; }

                /// <summary>
                /// 获取或设置抢购活动信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limit_discount_info")]
                [System.Text.Json.Serialization.JsonPropertyName("limit_discount_info")]
                public Types.LimitedDiscount? LimitedDiscount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置橱窗商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product Product { get; set; } = default!;
    }
}
