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

                    public class SKUDeliverInfo : ChannelsECProductAddRequest.Types.SKUDeliverInfo
                    {
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

            public class Limitation : ChannelsECProductAddRequest.Types.Limitation
            {
            }

            public class Express : ChannelsECProductAddRequest.Types.Express
            {
            }

            public class ExtraService : ChannelsECProductAddRequest.Types.ExtraService
            {
            }

            public class TimingOnSale : ChannelsECProductUpdateRequest.Types.TimingOnSale
            {
            }

            public class SPUDeliverInfo
            {
                public static class Types
                {
                    public class SKUDeliverInfo : ChannelsECProductUpdateRequest.Types.SKUDeliverInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置是否生效。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_spu_range")]
                [System.Text.Json.Serialization.JsonPropertyName("is_spu_range")]
                public bool? IsSPURange { get; set; }

                /// <summary>
                /// 获取或设置商品预售信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_deliver_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_deliver_info")]
                public Types.SKUDeliverInfo? SKUDeliverInfo { get; set; }
            }

            public class Aftersale : ChannelsECProductUpdateRequest.Types.Aftersale
            {
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

        /// <summary>
        /// 获取或设置是否在店铺首页隐藏。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hide_in_window")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("hide_in_window")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsHideInWindow { get; set; }

        /// <summary>
        /// 获取或设置售后信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_info")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_info")]
        public Types.Aftersale? Aftersale { get; set; }

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
    }
}
