using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/auditfree 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductAuditFreeRequest : WechatApiRequest, IInferable<ChannelsECProductAuditFreeRequest, ChannelsECProductAuditFreeResponse>
    {
        public static class Types
        {
            public class SKU
            {
                public static class Types
                {
                    public class StockInfo
                    {
                        /// <summary>
                        /// 获取或设置修改类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("diff_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("diff_type")]
                        public int? DiffType { get; set; }

                        /// <summary>
                        /// 获取或设置修改数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("num")]
                        [System.Text.Json.Serialization.JsonPropertyName("num")]
                        public int DiffCount { get; set; }
                    }

                    public class SKUDeliverInfo
                    {
                        /// <summary>
                        /// 获取或设置 SKU 库存情况。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("stock_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("stock_type")]
                        public int StockType { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 发货节点。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("full_payment_presale_delivery_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("full_payment_presale_delivery_type")]
                        public int? FullPaymentPresaleDeliveryType { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 预售周期开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("presale_begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("presale_begin_time")]
                        public long? PresaleBeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 预售周期结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("presale_end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("presale_end_time")]
                        public long? PresaleEndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 发货时效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("full_payment_presale_delivery_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("full_payment_presale_delivery_time")]
                        public int FullPaymentPresaleDeliveryTime { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置商品编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_code")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_code")]
                public string? SKUCode { get; set; }

                /// <summary>
                /// 获取或设置售价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_price")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                public int? SalePrice { get; set; }

                /// <summary>
                /// 获取或设置库存信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_info")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_info")]
                public Types.StockInfo? StockInfo { get; set; }

                /// <summary>
                /// 获取或设置商品配送信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_deliver_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_deliver_info")]
                public Types.SKUDeliverInfo? SKUDeliverInfo { get; set; }

                /// <summary>
                /// 获取或设置是否删除。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_delete")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_delete")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                public bool? IsDeleted { get; set; }
            }

            public class Limitation
            {
                /// <summary>
                /// 获取或设置限购周期类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("period_type")]
                [System.Text.Json.Serialization.JsonPropertyName("period_type")]
                public int? PeriodType { get; set; }

                /// <summary>
                /// 获取或设置限购数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("limited_buy_num")]
                [System.Text.Json.Serialization.JsonPropertyName("limited_buy_num")]
                public int? LimitedBuyCount { get; set; }
            }

            public class Express
            {
                /// <summary>
                /// 获取或设置运费模板 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_id")]
                [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                public long? TemplateId { get; set; }

                /// <summary>
                /// 获取或设置商品重量（单位：克）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("weight")]
                [System.Text.Json.Serialization.JsonPropertyName("weight")]
                public int? Weight { get; set; }
            }

            public class ExtraService
            {
                /// <summary>
                /// 获取或设置是否支持七天无理由退货。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("seven_day_return")]
                [System.Text.Json.Serialization.JsonPropertyName("seven_day_return")]
                public int? SevenDayReturn { get; set; }

                /// <summary>
                /// 获取或设置是否支持运费险。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance")]
                public int? FreightInsurance { get; set; }

                /// <summary>
                /// 获取或设置是否支持假一赔三。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fake_one_pay_three")]
                [System.Text.Json.Serialization.JsonPropertyName("fake_one_pay_three")]
                public int? FakeOnePayThree { get; set; }

                /// <summary>
                /// 获取或设置是否支持坏损包退。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("damage_guarantee")]
                [System.Text.Json.Serialization.JsonPropertyName("damage_guarantee")]
                public int? DamageGuarantee { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("spu_code")]
        [System.Text.Json.Serialization.JsonPropertyName("spu_code")]
        public string? SPUCode { get; set; }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public IList<Types.SKU>? SKUList { get; set; } = new List<Types.SKU>();

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
    }
}
