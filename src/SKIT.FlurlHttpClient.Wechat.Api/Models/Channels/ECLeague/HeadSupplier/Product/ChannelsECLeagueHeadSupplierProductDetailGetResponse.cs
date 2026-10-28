namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/productdetail/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierProductDetailGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class ProductInfo
                    {
                        public static class Types
                        {
                            public class Detail : ChannelsECProductGetResponse.Types.Product.Types.Detail
                            {
                            }

                            public class Category : ChannelsECProductGetResponse.Types.Product.Types.Category
                            {
                            }

                            public class HeadVideo : ChannelsECProductGetResponse.Types.Product.Types.HeadVideo
                            {
                            }

                            public class SKU : ChannelsECProductGetResponse.Types.Product.Types.SKU
                            {
                                /// <summary>
                                /// 获取或设置用户视角普惠价（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("user_inclusive_price")]
                                [System.Text.Json.Serialization.JsonPropertyName("user_inclusive_price")]
                                public int? UserInclusivePrice { get; set; }
                            }

                            public class ExtraService : ChannelsECProductGetResponse.Types.Product.Types.ExtraService
                            {
                            }

                            public class ProductSpringFestivalDeliveryConfig
                            {
                                public static class Types
                                {
                                    public class DeliveryTime
                                    {
                                        /// <summary>
                                        /// 获取或设置开始时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("start_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                                        public long StartTimestamp { get; set; }

                                        /// <summary>
                                        /// 获取或设置结束时间戳。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("end_time")]
                                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                                        public long? EndTimestamp { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置春节可发货时段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("delivery_time_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("delivery_time_list")]
                                public List<Types.DeliveryTime>? DeliveryTimeList { get; set; }

                                /// <summary>
                                /// 获取或设置春节打烊延迟发货时间戳。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("predict_delivery_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("predict_delivery_time")]
                                public long? PredictDeliveryTimestamp { get; set; }

                                /// <summary>
                                /// 获取或设置春节可发货时段时效（单位：小时）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("send_time_hours")]
                                [System.Text.Json.Serialization.JsonPropertyName("send_time_hours")]
                                public int? SendTimeHours { get; set; }

                                /// <summary>
                                /// 获取或设置是否不受春节影响。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("unaffected_by_newyear")]
                                [System.Text.Json.Serialization.JsonPropertyName("unaffected_by_newyear")]
                                public bool IsUnaffectedByNewYear { get; set; }
                            }

                            public class FreightInfo
                            {
                                public static class Types
                                {
                                    public class Address
                                    {
                                        /// 获取或设置省份。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("province_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                                        public string? ProvinceName { get; set; }

                                        /// <summary>
                                        /// 获取或设置城市。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("city_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                                        public string? CityName { get; set; }

                                        /// <summary>
                                        /// 获取或设置区县。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("county_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("county_name")]
                                        public string? DistrictName { get; set; }

                                        /// <summary>
                                        /// 获取或设置详细地址。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("detail_info")]
                                        [System.Text.Json.Serialization.JsonPropertyName("detail_info")]
                                        public string? Detail { get; set; }

                                        /// <summary>
                                        /// 获取或设置国家码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("national_code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("national_code")]
                                        public int? NationalCode { get; set; }

                                        /// <summary>
                                        /// 获取或设置邮政编码。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("postal_code")]
                                        [System.Text.Json.Serialization.JsonPropertyName("postal_code")]
                                        public string? PostalCode { get; set; }
                                    }

                                    public class ConditionFreeDetail
                                    {
                                        /// <summary>
                                        /// 获取或设置支持的地址列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("address_infos")]
                                        [System.Text.Json.Serialization.JsonPropertyName("address_infos")]
                                        public List<Address>? AddressList { get; set; }

                                        /// <summary>
                                        /// 获取或设置最低件数。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("min_piece")]
                                        [System.Text.Json.Serialization.JsonPropertyName("min_piece")]
                                        public int MinPiece { get; set; }

                                        /// <summary>
                                        /// 获取或设置最低重量（单位：千克）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("min_weight")]
                                        [System.Text.Json.Serialization.JsonPropertyName("min_weight")]
                                        public int MinWeight { get; set; }

                                        /// <summary>
                                        /// 获取或设置最低金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("min_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("min_amount")]
                                        public int MinAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置计费方式是否已设置。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("valuation_flag")]
                                        [System.Text.Json.Serialization.JsonPropertyName("valuation_flag")]
                                        public int ValuationFlag { get; set; }

                                        /// <summary>
                                        /// 获取或设置金额是否已设置。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("amount_flag")]
                                        [System.Text.Json.Serialization.JsonPropertyName("amount_flag")]
                                        public int AmountFlag { get; set; }
                                    }

                                    public class FreightCalculateMethod
                                    {
                                        /// <summary>
                                        /// 获取或设置支持的地址列表。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("address_infos")]
                                        [System.Text.Json.Serialization.JsonPropertyName("address_infos")]
                                        public List<Address>? AddressList { get; set; }

                                        /// <summary>
                                        /// 获取或设置是否默认运费。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("is_default")]
                                        [System.Text.Json.Serialization.JsonPropertyName("is_default")]
                                        public bool IsDefault { get; set; }

                                        /// <summary>
                                        /// 获取或设置快递公司 ID。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                                        public string? DeliveryId { get; set; }

                                        /// <summary>
                                        /// 获取或设置首段运费数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("first_val_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("first_val_amount")]
                                        public int FirstValueAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置首段运费金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("first_price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("first_price")]
                                        public int FirstPrice { get; set; }

                                        /// <summary>
                                        /// 获取或设置续费运费数量。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("second_val_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("second_val_amount")]
                                        public int SecondValueAmount { get; set; }

                                        /// <summary>
                                        /// 获取或设置续费运费金额（单位：分）。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("second_price")]
                                        [System.Text.Json.Serialization.JsonPropertyName("second_price")]
                                        public int SecondPrice { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置发货时间期限类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("send_time")]
                                [System.Text.Json.Serialization.JsonPropertyName("send_time")]
                                public string? SendTimeType { get; set; }

                                /// <summary>
                                /// 获取或设置计费类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("valuation_type")]
                                [System.Text.Json.Serialization.JsonPropertyName("valuation_type")]
                                public int ValuationType { get; set; }

                                /// <summary>
                                /// 获取或设置发货地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("address_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("address_info")]
                                public Types.Address? Address { get; set; }

                                /// <summary>
                                /// 获取或设置计费方式。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_method")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_method")]
                                public int ShippingMethod { get; set; }

                                /// <summary>
                                /// 获取或设置条件包邮信息列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("condition_free_detail_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("condition_free_detail_list")]
                                public List<Types.ConditionFreeDetail>? ConditionFreeDetailList { get; set; }

                                /// <summary>
                                /// 获取或设置具体计费信息列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("freight_calc_method_list")]
                                [System.Text.Json.Serialization.JsonPropertyName("freight_calc_method_list")]
                                public List<Types.FreightCalculateMethod>? FreightCalculateMethodList { get; set; }

                                /// <summary>
                                /// 获取或设置不发货地区列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("not_send_area")]
                                [System.Text.Json.Serialization.JsonPropertyName("not_send_area")]
                                public List<Types.Address>? NotSendAreaList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置商品标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string? Title { get; set; }

                        /// <summary>
                        /// 获取或设置商品副标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sub_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("sub_title")]
                        public string? SubTitle { get; set; }

                        /// <summary>
                        /// 获取或设置商品短标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("short_title")]
                        [System.Text.Json.Serialization.JsonPropertyName("short_title")]
                        public string? ShortTitle { get; set; }

                        /// <summary>
                        /// 获取或设置主图 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_imgs")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
                        public List<string>? HeadImageUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置商品详情信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("desc_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("desc_info")]
                        public Types.Detail? Detail { get; set; }

                        /// <summary>
                        /// 获取或设置新版商品类目列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("cats_v2")]
                        [System.Text.Json.Serialization.JsonPropertyName("cats_v2")]
                        public List<Types.Category>? CategoryV2List { get; set; }

                        /// <summary>
                        /// 获取或设置商品头图视频列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_video_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_video_info")]
                        public List<Types.HeadVideo>? HeadVideoList { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("skus")]
                        [System.Text.Json.Serialization.JsonPropertyName("skus")]
                        public List<Types.SKU>? SKUList { get; set; }

                        /// <summary>
                        /// 获取或设置商品状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }

                        /// <summary>
                        /// 获取或设置近 30 天销量范围。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("monthly_sales_range")]
                        [System.Text.Json.Serialization.JsonPropertyName("monthly_sales_range")]
                        public int MonthlySalesRange { get; set; }

                        /// <summary>
                        /// 获取或设置服务保障信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("extra_service")]
                        [System.Text.Json.Serialization.JsonPropertyName("extra_service")]
                        public Types.ExtraService? ExtraService { get; set; }

                        /// <summary>
                        /// 获取或设置春节不打烊信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_spring_festival_delivery_config")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_spring_festival_delivery_config")]
                        public Types.ProductSpringFestivalDeliveryConfig? ProductSpringFestivalDeliveryConfig { get; set; }

                        /// <summary>
                        /// 获取或设置物流信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_info")]
                        public Types.FreightInfo? FreightInfo { get; set; }

                        /// <summary>
                        /// 获取或设置是否有单品资质。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("has_qualification")]
                        [System.Text.Json.Serialization.JsonPropertyName("has_qualification")]
                        public bool HasQualification { get; set; }

                        /// <summary>
                        /// 获取或设置是否是热门品牌。
                        /// </summary>
                        [Obsolete("相关接口或字段于 2026-05-15 下线。")]
                        [Newtonsoft.Json.JsonProperty("is_hot_brand")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_hot_brand")]
                        public bool IsHotBrand { get; set; }

                        /// <summary>
                        /// 获取或设置是否是品牌好物。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_brand_good")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_brand_good")]
                        public bool IsBrandGood { get; set; }

                        /// <summary>
                        /// 获取或设置好评率（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("good_evaluation_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("good_evaluation_ratio")]
                        public int GoodEvaluationRatio { get; set; }
                    }

                    public class ShopInfo
                    {
                        /// <summary>
                        /// 获取或设置小店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置小店图标 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("icon")]
                        [System.Text.Json.Serialization.JsonPropertyName("icon")]
                        public string? IconUrl { get; set; }

                        /// <summary>
                        /// 获取或设置小店评分。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("score")]
                        [System.Text.Json.Serialization.JsonPropertyName("score")]
                        public int Score { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_id")]
                [System.Text.Json.Serialization.JsonPropertyName("product_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                public Types.ProductInfo? ProductInfo { get; set; }

                /// <summary>
                /// 获取或设置店铺信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop")]
                [System.Text.Json.Serialization.JsonPropertyName("shop")]
                public Types.ShopInfo? ShopInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product? Product { get; set; }
    }
}
