namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class HeadVideo : ChannelsECProductAddRequest.Types.HeadVideo
                    {
                    }

                    public class Detail : ChannelsECProductAddRequest.Types.Detail
                    {
                    }

                    public class Category : ChannelsECProductAddRequest.Types.Category
                    {
                    }

                    public class Attribute : ChannelsECProductAddRequest.Types.Attribute
                    {
                    }

                    public class Express : ChannelsECProductAddRequest.Types.Express
                    {
                    }

                    public abstract class __zz__SKU : ChannelsECProductAddRequest.Types.__zz__SKU
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }

                    public class SKU : __zz__SKU
                    {
                        /// <summary>
                        /// 获取或设置商品属性列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_attrs")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_attrs")]
                        public List<Attribute>? AttributeList { get; set; }

                        /// <summary>
                        /// 获取或设置商品配送信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_deliver_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_deliver_info")]
                        public SKUDeliverInfo? SKUDeliverInfo { get; set; }
                    }

                    public class SKUDeliverInfo : ChannelsECProductAddRequest.Types.SKUDeliverInfo
                    {
                    }

                    public class Limitation : ChannelsECProductAddRequest.Types.Limitation
                    {
                    }

                    public class ExtraService : ChannelsECProductAddRequest.Types.ExtraService
                    {
                    }

                    public class Aftersale : ChannelsECProductAddRequest.Types.Aftersale
                    {
                    }

                    public class Qualification : ChannelsECProductAddRequest.Types.Qualification
                    {
                    }

                    public class SizeChart : ChannelsECProductAddRequest.Types.__zz__SizeChart
                    {
                        public static class Types
                        {
                            public class Specification : ChannelsECProductAddRequest.Types.SizeChart.Types.__zz__Specification
                            {
                                public static class Types
                                {
                                    public class SpecificationValue : ChannelsECProductAddRequest.Types.SizeChart.Types.Specification.Types.SpecificationValue
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置属性值映射列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("value_list")]
                                public List<Types.SpecificationValue>? ValueList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置尺码规格列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("specification_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("specification_list")]
                        public List<Types.Specification>? SpecificationList { get; set; }
                    }

                    public class TimingOnSale : ChannelsECProductAddRequest.Types.TimingOnSale
                    {
                        /// <summary>
                        /// 获取或设置待开售任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("task_id")]
                        public long? TaskId { get; set; }
                    }

                    public class SPUDeliverInfo : ChannelsECProductAddRequest.Types.__zz__SPUDeliverInfo
                    {
                        /// <summary>
                        /// 获取或设置商品预售信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_deliver_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_deliver_info")]
                        public SKUDeliverInfo? SKUDeliverInfo { get; set; }
                    }

                    public class SupplySource : ChannelsECProductAddRequest.Types.SupplySource
                    {
                    }
                }

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
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置商品短标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("short_title")]
                [System.Text.Json.Serialization.JsonPropertyName("short_title")]
                public string? ShortTitle { get; set; }

                /// <summary>
                /// 获取或设置商品头图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_imgs")]
                [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
                public List<string>? HeadImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置商品头图视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_videos")]
                [System.Text.Json.Serialization.JsonPropertyName("head_videos")]
                public List<Types.HeadVideo>? HeadVideoList { get; set; }

                /// <summary>
                /// 获取或设置商品详情信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("desc_info")]
                [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
                public Types.Detail? Detail { get; set; }

                /// <summary>
                /// 获取或设置商品头图 3:4 主图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("vertical_head_imgs")]
                [System.Text.Json.Serialization.JsonPropertyName("vertical_head_imgs")]
                public List<string>? VerticalHeadImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置商品头图白底图 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("white_bg_imgs")]
                [System.Text.Json.Serialization.JsonPropertyName("white_bg_imgs")]
                public List<string>? WhiteBackgroundImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置商品类目列表。
                /// </summary>
                [Obsolete("相关接口或字段于 2024-10-28 下线。")]
                [Newtonsoft.Json.JsonProperty("cats")]
                [System.Text.Json.Serialization.JsonPropertyName("cats")]
                public List<Types.Category>? CategoryList { get; set; }

                /// <summary>
                /// 获取或设置新版商品类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cats_v2")]
                [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                public List<Types.Category>? CategoryV2List { get; set; }

                /// <summary>
                /// 获取或设置商品属性列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attrs")]
                [System.Text.Json.Serialization.JsonPropertyName("attrs")]
                public List<Types.Attribute>? AttributeList { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_code")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_code")]
                public string? SPUCode { get; set; }

                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? BrandId { get; set; }

                /// <summary>
                /// 获取或设置发货方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deliver_method")]
                [System.Text.Json.Serialization.JsonPropertyName("deliver_method")]
                public int? DeliverMethod { get; set; }

                /// <summary>
                /// 获取或设置运费信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("express_info")]
                [System.Text.Json.Serialization.JsonPropertyName("express_info")]
                public Types.Express? Express { get; set; }

                /// <summary>
                /// 获取或设置商品状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置商品子状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_status")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_status")]
                public int? SubStatus { get; set; }

                /// <summary>
                /// 获取或设置商品草稿状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edit_status")]
                [System.Text.Json.Serialization.JsonPropertyName("edit_status")]
                public int EditingStatus { get; set; }

                /// <summary>
                /// 获取或设置 SKU 最低价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("min_price")]
                [System.Text.Json.Serialization.JsonPropertyName("min_price")]
                public int MinPrice { get; set; }

                /// <summary>
                /// 获取或设置 SKU 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("skus")]
                [System.Text.Json.Serialization.JsonPropertyName("skus")]
                public List<Types.SKU>? SKUList { get; set; }

                /// <summary>
                /// 获取或设置限购信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limited_info")]
                [System.Text.Json.Serialization.JsonPropertyName("limited_info")]
                public Types.Limitation? Limitation { get; set; }

                /// <summary>
                /// 获取或设置额外的服务信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_service")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_service")]
                public Types.ExtraService? ExtraService { get; set; }

                /// <summary>
                /// 获取或设置商品类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_type")]
                [System.Text.Json.Serialization.JsonPropertyName("product_type")]
                public int? ProductType { get; set; }

                /// <summary>
                /// 获取或设置商品草稿最近一次修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("edit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("edit_time")]
                public long EditTimestamp { get; set; }

                /// <summary>
                /// 获取或设置导入的来源商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("src_product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("src_product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long? SourceProductId { get; set; }

                /// <summary>
                /// 获取或设置总销量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_sold_num")]
                [System.Text.Json.Serialization.JsonPropertyName("total_sold_num")]
                public int? TotalSoldCount { get; set; }

                /// <summary>
                /// 获取或设置是否在店铺首页隐藏。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("hide_in_window")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("hide_in_window")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                public bool? IsHideInWindow { get; set; }

                /// <summary>
                /// 获取或设置售后地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("after_sale_info")]
                [System.Text.Json.Serialization.JsonPropertyName("after_sale_info")]
                public Types.Aftersale? Aftersale { get; set; }

                /// <summary>
                /// 获取或设置售后说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("aftersale_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("aftersale_desc")]
                public string? AftersaleDescription { get; set; }

                /// <summary>
                /// 获取或设置商品资质列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_qua_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("product_qua_infos")]
                public List<Types.Qualification>? QualificationList { get; set; }

                /// <summary>
                /// 获取或设置尺码表信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("size_chart")]
                [System.Text.Json.Serialization.JsonPropertyName("size_chart")]
                public Types.SizeChart? SizeChart { get; set; }

                /// <summary>
                /// 获取或设置待开售信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timing_onsale_info")]
                [System.Text.Json.Serialization.JsonPropertyName("timing_onsale_info")]
                public Types.TimingOnSale? TimingOnSale { get; set; }

                /// <summary>
                /// 获取或设置商品预售信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_deliver_info")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_deliver_info")]
                public Types.SPUDeliverInfo? SPUDeliverInfo { get; set; }

                /// <summary>
                /// 获取或设置供货货品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supply_source")]
                [System.Text.Json.Serialization.JsonPropertyName("supply_source")]
                public Types.SupplySource? SupplySource { get; set; }

                /// <summary>
                /// 获取或设置发布模式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("release_mode")]
                public int? ReleaseMode { get; set; }
            }

            public class SaleLimitInfo
            {
                /// <summary>
                /// 获取或设置是否受到管控。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_limited")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_limited")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                public bool IsLimited { get; set; }

                /// <summary>
                /// 获取或设置售卖限制标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string? Title { get; set; }

                /// <summary>
                /// 获取或设置售卖限制描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_title")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
                public string? SubTitle { get; set; }
            }

            public class InfoScoreInfo
            {
                public static class Types
                {
                    public class SubScore
                    {
                        /// <summary>
                        /// 获取或设置字段名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("busi_data_field_api")]
                        [System.Text.Json.Serialization.JsonPropertyName("busi_data_field_api")]
                        public string? Field { get; set; }

                        /// <summary>
                        /// 获取或设置字段描述。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("field_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("field_name")]
                        public string? FieldName { get; set; }

                        /// <summary>
                        /// 获取或设置审核备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_remark")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_remark")]
                        public string? AuditRemark { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品信息质量总分等级。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("release_mode")]
                public int ScoreLevel { get; set; }

                /// <summary>
                /// 获取或设置商品信息质量子项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_score_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_score_list")]
                public List<Types.SubScore>? SubScoreList { get; set; }
            }

            public class CMPPriceInfo
            {
                public static class Types
                {
                    public class SKUResult
                    {
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        public long SKUId { get; set; }

                        /// <summary>
                        /// 获取或设置是否被检测为高价。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_expensive_warning")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_expensive_warning")]
                        public bool IsExpensiveWarning { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置检测状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置 SKU 高价预警检测结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_result_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_result_list")]
                public List<Types.SKUResult>? SKUResultList { get; set; }
            }

            public class AuditInfo
            {
                /// <summary>
                /// 获取或设置提审的商品上架策略开关列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_strategy_flag_list")]
                [System.Text.Json.Serialization.JsonPropertyName("user_strategy_flag_list")]
                public List<int>? UserStrategyFlagList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置线上商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product? Product { get; set; }

        /// <summary>
        /// 获取或设置草稿商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("edit_product")]
        [System.Text.Json.Serialization.JsonPropertyName("edit_product")]
        public Types.Product? EditingProduct { get; set; }

        /// <summary>
        /// 获取或设置当日售卖上限提醒信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sale_limit_info")]
        [System.Text.Json.Serialization.JsonPropertyName("sale_limit_info")]
        public Types.SaleLimitInfo? SaleLimitInfo { get; set; }

        /// <summary>
        /// 获取或设置信息质量信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info_score")]
        [System.Text.Json.Serialization.JsonPropertyName("info_score")]
        public Types.InfoScoreInfo? InfoScoreInfo { get; set; }

        /// <summary>
        /// 获取或设置商品高价预警信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cmp_price_info")]
        [System.Text.Json.Serialization.JsonPropertyName("cmp_price_info")]
        public Types.CMPPriceInfo? CMPPriceInfo { get; set; }

        /// <summary>
        /// 获取或设置审核信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_info")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
        public Types.AuditInfo? AuditInfo { get; set; }
    }
}
