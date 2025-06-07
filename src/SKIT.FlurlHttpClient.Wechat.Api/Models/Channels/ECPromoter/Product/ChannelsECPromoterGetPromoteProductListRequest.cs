using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_promote_product_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetPromoteProductListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetPromoteProductListRequest, ChannelsECPromoterGetPromoteProductListResponse>
    {
        public static class Types
        {
            public class SPUItemCondition
            {
                public static class Types
                {
                    public class Range
                    {
                        /// <summary>
                        /// 获取或设置最小值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("min")]
                        [System.Text.Json.Serialization.JsonPropertyName("min")]
                        public long Mininum { get; set; }

                        /// <summary>
                        /// 获取或设置最大值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("max")]
                        [System.Text.Json.Serialization.JsonPropertyName("max")]
                        public long Maxinum { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置售卖价区间信息（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("selling_price_range")]
                [System.Text.Json.Serialization.JsonPropertyName("selling_price_range")]
                public Types.Range? SellingPriceRange { get; set; }

                /// <summary>
                /// 获取或设置月销量区间信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("monthly_sales_range")]
                [System.Text.Json.Serialization.JsonPropertyName("monthly_sales_range")]
                public Types.Range? MonthlySalesRange { get; set; }

                /// <summary>
                /// 获取或设置服务费率区间信息（单位：十万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_fee_rate_range")]
                [System.Text.Json.Serialization.JsonPropertyName("service_fee_rate_range")]
                public Types.Range? ServiceFeeRateRange { get; set; }

                /// <summary>
                /// 获取或设置佣金率区间信息（单位：十万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_rate_range")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_rate_range")]
                public Types.Range? CommissionRateRange { get; set; }

                /// <summary>
                /// 获取或设置推广时间戳范围信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promote_time_range")]
                [System.Text.Json.Serialization.JsonPropertyName("promote_time_range")]
                public Types.Range? PromoteTimestampRange { get; set; }

                /// <summary>
                /// 获取或设置保障标识信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flags")]
                [System.Text.Json.Serialization.JsonPropertyName("flags")]
                public IList<string>? FlagList { get; set; }
            }

            public class Category
            {
                /// <summary>
                /// 获取或设置商品类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("category_id")]
                public long? CategoryId { get; set; }

                /// <summary>
                /// 获取或设置商品类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                public string? CategoryName { get; set; }

                /// <summary>
                /// 获取或设置一级类目 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_ids_1")]
                [System.Text.Json.Serialization.JsonPropertyName("category_ids_1")]
                public IList<long>? Category1stIdList { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_ids_2")]
                [System.Text.Json.Serialization.JsonPropertyName("category_ids_2")]
                public IList<long>? Category2ndIdList { get; set; }

                /// <summary>
                /// 获取或设置三级类目 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("category_ids_3")]
                [System.Text.Json.Serialization.JsonPropertyName("category_ids_3")]
                public IList<long>? Category3rdIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string? ShopAppId { get; set; }

        /// <summary>
        /// 获取或设置搜索关键词。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("keyword")]
        public string? Keyword { get; set; }

        /// <summary>
        /// 获取或设置计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_type")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        public int PlanType { get; set; }

        /// <summary>
        /// 获取或设置商品查询条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_item_condition")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_item_condition")]
        public Types.SPUItemCondition? SPUItemCondition { get; set; }

        /// <summary>
        /// 获取或设置类目查询条件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category")]
        [System.Text.Json.Serialization.JsonPropertyName("category")]
        public Types.Category? Category { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
