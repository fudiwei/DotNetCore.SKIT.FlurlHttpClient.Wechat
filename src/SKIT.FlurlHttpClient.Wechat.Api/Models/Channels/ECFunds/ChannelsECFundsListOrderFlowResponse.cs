namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/funds/listorderflow 接口的响应。</para>
    /// </summary>
    public class ChannelsECFundsListOrderFlowResponse : WechatApiResponse
    {
        public static class Types
        {
            public class OrderFlow
            {
                public static class Types
                {
                    public class Product
                    {
                        public static class Types
                        {
                            public class ParamItem
                            {
                                /// <summary>
                                /// 获取或设置规格名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("key")]
                                [System.Text.Json.Serialization.JsonPropertyName("key")]
                                public string? Key { get; set; }

                                /// <summary>
                                /// 获取或设置规格值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("value")]
                                [System.Text.Json.Serialization.JsonPropertyName("value")]
                                public string? Value { get; set; }
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
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string? ProductName { get; set; }

                        /// <summary>
                        /// 获取或设置商品规格列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("param_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("param_list")]
                        public List<Types.ParamItem>? ParamList { get; set; }

                        /// <summary>
                        /// 获取或设置商品销售价格（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_price")]
                        public int SalePrice { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("count")]
                        [System.Text.Json.Serialization.JsonPropertyName("count")]
                        public int Count { get; set; }

                        /// <summary>
                        /// 获取或设置是否是赠品。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_gift")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_gift")]
                        public bool IsGift { get; set; }
                    }

                    public class PostSettlementExpense
                    {
                        /// <summary>
                        /// 获取或设置买家退款。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("buyer_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("buyer_refund_amount")]
                        public int BuyerRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台优惠退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_discount_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_discount_refund_amount")]
                        public int PlatformDiscountRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置达人退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promoter_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promoter_refund_amount")]
                        public int PromoterRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运费险保费。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_insurance_make_up_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_make_up_amount")]
                        public int FreightInsuranceMakeUpAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运费险补缴本单结算状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_insurance_make_up_settle_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_make_up_settle_state")]
                        public int FreightInsuranceMakeUpSettleState { get; set; }

                        /// <summary>
                        /// 获取或设置运费险补缴本单的订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("freight_insurance_make_up_order_id")]
                        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericStringReadOnlyConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_make_up_order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                        public string? FreightInsuranceMakeUpOrderId { get; set; }
                    }

                    public class SupplierPlatformCommission
                    {
                        /// <summary>
                        /// 获取或设置结算金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_amount")]
                        public int SettleAmount { get; set; }

                        /// <summary>
                        /// 获取或设置结算时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_time")]
                        public long SettleTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置结算状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settle_state")]
                        [System.Text.Json.Serialization.JsonPropertyName("settle_state")]
                        public int SettleState { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericStringReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_state")]
                [System.Text.Json.Serialization.JsonPropertyName("order_state")]
                public int OrderState { get; set; }

                /// <summary>
                /// 获取或设置订单结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_settle_state")]
                [System.Text.Json.Serialization.JsonPropertyName("order_settle_state")]
                public int OrderSettleState { get; set; }

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_create_time")]
                public long OrderCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_paid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_paid_time")]
                public long OrderPaidTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_pay_method")]
                [System.Text.Json.Serialization.JsonPropertyName("order_pay_method")]
                public int OrderPayMethod { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置商户实收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_received_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_received_amount")]
                public int MerchantReceivedAmount { get; set; }

                /// <summary>
                /// 获取或设置支出金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expense_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("expense_amount")]
                public int ExpenseAmount { get; set; }

                /// <summary>
                /// 获取或设置结算金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_settle_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_settle_amount")]
                public int MerchantSettleAmount { get; set; }

                /// <summary>
                /// 获取或设置商家货款结算时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_settle_time")]
                public long MerchantSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置商品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_list")]
                [System.Text.Json.Serialization.JsonPropertyName("product_list")]
                public List<Types.Product>? ProductList { get; set; }

                /// <summary>
                /// 获取或设置商品总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("product_total_amount")]
                public int ProductTotalAmount { get; set; }

                /// <summary>
                /// 获取或设置运费金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_amount")]
                public int FreightAmount { get; set; }

                /// <summary>
                /// 获取或设置改价金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("change_down_price")]
                [System.Text.Json.Serialization.JsonPropertyName("change_down_price")]
                public int ChangeDownPrice { get; set; }

                /// <summary>
                /// 获取或设置商户优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mch_discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("mch_discount_amount")]
                public int MerchantDiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置积分抵扣金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score_discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("score_discount_amount")]
                public int ScoreDiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置用户实付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_paid_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_paid_amount")]
                public int BuyerPaidAmount { get; set; }

                /// <summary>
                /// 获取或设置达人优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_discount_amount")]
                public int PromoterDiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置平台优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                public int PlatformDiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置国家补贴金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("national_subsidy_discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("national_subsidy_discount_amount")]
                public int NationalSubsidyDiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置补交运费。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_make_up_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_make_up_amount")]
                public int FreightMakeUpAmount { get; set; }

                /// <summary>
                /// 获取或设置跨店优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cross_shop_discount_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("cross_shop_discount_amount")]
                public int CrossShopDiscountAmount { get; set; }

                /// <summary>
                /// 获取或设置用户退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_refund_amount")]
                public int BuyerRefundAmount { get; set; }

                /// <summary>
                /// 获取或设置平台优惠退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_discount_refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_refund_amount")]
                public int PlatformDiscountRefundAmount { get; set; }

                /// <summary>
                /// 获取或设置达人优惠退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_discount_refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_discount_refund_amount")]
                public int PromoterDiscountRefundAmount { get; set; }

                /// <summary>
                /// 获取或设置原技术服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("original_platform_commission_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("original_platform_commission_amount")]
                public int OriginalPlatformCommissionAmount { get; set; }

                /// <summary>
                /// 获取或设置技术服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_commission_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_commission_amount")]
                public int PlatformCommissionAmount { get; set; }

                /// <summary>
                /// 获取或设置运费险补贴减免技术服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_subsidy_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_subsidy_amount")]
                public int FreightInsuranceSubsidyAmount { get; set; }

                /// <summary>
                /// 获取或设置机构服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_commission_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_commission_amount")]
                public int SupplierCommissionAmount { get; set; }

                /// <summary>
                /// 获取或设置机构服务费结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_commission_settle_state")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_commission_settle_state")]
                public int SupplierCommissionSettleState { get; set; }

                /// <summary>
                /// 获取或设置达人服务费（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_commission_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_commission_amount")]
                public int PromoterCommissionAmount { get; set; }

                /// <summary>
                /// 获取或设置达人服务费结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_commission_settle_state")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_commission_settle_state")]
                public int PromoterCommissionSettleState { get; set; }

                /// <summary>
                /// 获取或设置运费险金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_amount")]
                public int FreightInsuranceAmount { get; set; }

                /// <summary>
                /// 获取或设置运费险结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_settle_state")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_settle_state")]
                public int FreightInsuranceSettleState { get; set; }

                /// <summary>
                /// 获取或设置运费险补缴他单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_make_up_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_make_up_amount")]
                public long FreightInsuranceMakeUpAmount { get; set; }

                /// <summary>
                /// 获取或设置运费险补缴他单订单 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_make_up_order_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_make_up_order_id_list")]
                public List<string>? FreightInsuranceMakeUpOrderIdList { get; set; }

                /// <summary>
                /// 获取或设置技术服务费结算时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_commission_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_commission_settle_time")]
                public long PlatformCommissionSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置达人服务费结算时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_commission_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_commission_settle_time")]
                public long PromoterCommissionSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置机构服务费结算时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_commission_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_commission_settle_time")]
                public long SupplierCommissionSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置运费险结算时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_settle_time")]
                public long FreightInsuranceSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置运费险补缴他单结算时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_make_up_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_make_up_settle_time")]
                public long FreightInsuranceMakeUpSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置预付运费退回金额。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pre_freight_refund_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("pre_freight_refund_amount")]
                public int PreFreightRefundAmount { get; set; }

                /// <summary>
                /// 获取或设置结算后支出信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("post_settlement_expense")]
                [System.Text.Json.Serialization.JsonPropertyName("post_settlement_expense")]
                public Types.PostSettlementExpense? PostSettlementExpense { get; set; }

                /// <summary>
                /// 获取或设置结算前退款。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_before_settlement")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_before_settlement")]
                public int RefundBeforeSettlement { get; set; }

                /// <summary>
                /// 获取或设置其他支出。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("other_expense_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("other_expense_amount")]
                public int OtherExpenseAmount { get; set; }

                /// <summary>
                /// 获取或设置平台服务费结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("platform_commission_settle_state")]
                [System.Text.Json.Serialization.JsonPropertyName("platform_commission_settle_state")]
                public int PlatformCommissionSettleState { get; set; }

                /// <summary>
                /// 获取或设置运费险补缴他单结算状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("freight_insurance_make_up_settle_state")]
                [System.Text.Json.Serialization.JsonPropertyName("freight_insurance_make_up_settle_state")]
                public int FreightInsuranceMakeUpSettleState { get; set; }

                /// <summary>
                /// 获取或设置同城配送门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("intra_city_shop_id")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericStringReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("intra_city_shop_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericStringReadOnlyConverter))]
                public string? IntraCityShopId { get; set; }

                /// <summary>
                /// 获取或设置供货商平台结算信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("supplier_platform_commission")]
                [System.Text.Json.Serialization.JsonPropertyName("supplier_platform_commission")]
                public Types.SupplierPlatformCommission? SupplierPlatformCommission { get; set; }

                /// <summary>
                /// 获取或设置首次商家货款结算时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_mch_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("first_mch_settle_time")]
                public long FirstMerchantSettleTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单流水列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data_list")]
        [System.Text.Json.Serialization.JsonPropertyName("data_list")]
        public List<Types.OrderFlow>? OrderFlowList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置下一页翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_ctx")]
        [System.Text.Json.Serialization.JsonPropertyName("page_ctx")]
        public string? NextCursor { get; set; }
    }
}
