namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/compass/shop/product/list/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECCompassShopProductListGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Product
            {
                public static class Types
                {
                    public class Data
                    {
                        /// <summary>
                        /// 获取或设置下单金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CreateGMV { get; set; }

                        /// <summary>
                        /// 获取或设置下单订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CreateCount { get; set; }

                        /// <summary>
                        /// 获取或设置下单人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_uv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CreateUV { get; set; }

                        /// <summary>
                        /// 获取或设置下单件数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("create_product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("create_product_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int CreateProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置成交金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayGMV { get; set; }

                        /// <summary>
                        /// 获取或设置成交订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayCount { get; set; }

                        /// <summary>
                        /// 获取或设置成交人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_uv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayUV { get; set; }

                        /// <summary>
                        /// 获取或设置成交件数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_product_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置净成交金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pure_pay_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pure_pay_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PurePayGMV { get; set; }

                        /// <summary>
                        /// 获取或设置净成交客单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_gmv_per_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_gmv_per_uv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PurePayGMVPerUV { get; set; }

                        /// <summary>
                        /// 获取或设置成交退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PayRefundGMV { get; set; }

                        /// <summary>
                        /// 获取或设置成交退款人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_uv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayRefundUV { get; set; }

                        /// <summary>
                        /// 获取或设置成交退款率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal PayRefundRatio { get; set; }

                        /// <summary>
                        /// 获取或设置发货后成交退款率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_after_send_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_after_send_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal PayRefundAfterSendRatio { get; set; }

                        /// <summary>
                        /// 获取或设置成交退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayRefundCount { get; set; }

                        /// <summary>
                        /// 获取或设置成交退款件数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_product_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int PayRefundProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置发货前成交退款率（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_refund_before_send_ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_before_send_ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public decimal PayRefundBeforeSendRatio { get; set; }

                        /// <summary>
                        /// 获取或设置退款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_gmv")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_gmv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long RefundGMV { get; set; }

                        /// <summary>
                        /// 获取或设置退款人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_uv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int RefundUV { get; set; }

                        /// <summary>
                        /// 获取或设置退款订单数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int RefundCount { get; set; }

                        /// <summary>
                        /// 获取或设置退款件数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_product_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_product_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int RefundProductCount { get; set; }

                        /// <summary>
                        /// 获取或设置商品点击人数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_click_uv")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_click_uv")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ProductClickUV { get; set; }

                        /// <summary>
                        /// 获取或设置商品点击次数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_click_cnt")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_click_cnt")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int ProductClickCount { get; set; }

                        /// <summary>
                        /// 获取或设置实际结算金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_actual_settle_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_actual_settle_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SellerActualSettleAmount { get; set; }

                        /// <summary>
                        /// 获取或设置实际服务费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_actual_commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_actual_commission")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PlatformActualCommission { get; set; }

                        /// <summary>
                        /// 获取或设置实际达人佣金支出（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finderuin_actual_commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("finderuin_actual_commission")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long FinderActualCommission { get; set; }

                        /// <summary>
                        /// 获取或设置实际团长佣金支出（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("captain_actual_commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("captain_actual_commission")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CaptainActualCommission { get; set; }

                        /// <summary>
                        /// 获取或设置预估结算金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_predict_settle_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_predict_settle_amount")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long SellerPredictSettleAmount { get; set; }

                        /// <summary>
                        /// 获取或设置预估服务费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_predict_commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_predict_commission")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long PlatformPredictCommission { get; set; }

                        /// <summary>
                        /// 获取或设置预估达人佣金支出（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("finderuin_predict_commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("finderuin_predict_commission")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long FinderuinPredictCommission { get; set; }

                        /// <summary>
                        /// 获取或设置预估团长佣金支出（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("captain_predict_commission")]
                        [System.Text.Json.Serialization.JsonPropertyName("captain_predict_commission")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long CaptainPredictCommission { get; set; }
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
                /// 获取或设置商品标题。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("title")]
                [System.Text.Json.Serialization.JsonPropertyName("title")]
                public string Title { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品头图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("head_img_url")]
                [System.Text.Json.Serialization.JsonPropertyName("head_img_url")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置商品价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置一级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("first_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("second_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long SecondCategoryId { get; set; }

                /// <summary>
                /// 获取或设置三级分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("third_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("third_category_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ThirdCategoryId { get; set; }

                /// <summary>
                /// 获取或设置统计数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("data")]
                [System.Text.Json.Serialization.JsonPropertyName("data")]
                public Types.Data Data { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_list")]
        [System.Text.Json.Serialization.JsonPropertyName("product_list")]
        public Types.Product[] ProductList { get; set; } = default!;
    }
}
