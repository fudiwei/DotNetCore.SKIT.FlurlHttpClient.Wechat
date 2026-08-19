namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/talent/getproductdatalist 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueTalentGetProductDataListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ProductData
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
                    }

                    public class CommissionInfo
                    {
                        /// <summary>
                        /// 获取或设置佣金分配类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commission_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("commission_type")]
                        public int CommissionType { get; set; }

                        /// <summary>
                        /// 获取或设置佣金费率（单位：十万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                        public int CommissionRatio { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                public long ProductId { get; set; } 

                /// <summary>
                /// 获取或设置商品数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_data")]
                [System.Text.Json.Serialization.JsonPropertyName("product_data")]
                public Types.ProductData ProductData { get; set; } = default!;

                /// <summary>
                /// 获取或设置佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_commission_info")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_commission_info")]
                public Types.CommissionInfo CommissionInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Data[] DataList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }
    }
}
