namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /payscore/serviceorder 接口的响应。</para>
    /// </summary>
    public class GetPayScoreServiceOrderByOutOrderNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class PostPayment : CreatePayScoreServiceOrderRequest.Types.PostPayment
            {
            }

            public class PostDiscount : CreatePayScoreServiceOrderRequest.Types.PostDiscount
            {
            }

            public class TimeRange : CreatePayScoreServiceOrderRequest.Types.TimeRange
            {
            }

            public class Location : CreatePayScoreServiceOrderRequest.Types.Location
            {
            }

            public class RiskFund : CreatePayScoreServiceOrderRequest.Types.RiskFund
            {
            }

            public abstract class __zz__Collection
            {
                /// <summary>
                /// 获取或设置收款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string? State { get; set; }

                /// <summary>
                /// 获取或设置总收款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                public int TotalAmount { get; set; }

                /// <summary>
                /// 获取或设置待收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paying_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("paying_amount")]
                public int PayingAmount { get; set; }

                /// <summary>
                /// 获取或设置已收金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_amount")]
                public int PaidAmount { get; set; }
            }

            public class Collection : __zz__Collection
            {
                public static class Types
                {
                    public abstract class __zz__CollectionDetail
                    {
                        /// <summary>
                        /// 获取或设置收款序号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seq")]
                        [System.Text.Json.Serialization.JsonPropertyName("seq")]
                        public int Sequence { get; set; }

                        /// <summary>
                        /// 获取或设置单笔收款金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("amount")]
                        public int Amount { get; set; }

                        /// <summary>
                        /// 获取或设置收款成功渠道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_type")]
                        public string? PaidType { get; set; }

                        /// <summary>
                        /// 获取或设置收款成功时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("paid_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.ISO8601CompactDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.ISO8601CompactDateTimeOffsetConverter))]
                        public DateTimeOffset? PaidTime { get; set; }

                        /// <summary>
                        /// 获取或设置微信支付交易单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                        public string? TransactionId { get; set; }
                    }

                    public class CollectionDetail : __zz__CollectionDetail
                    {
                        public static class Types
                        {
                            public abstract class __zz__Promotion : GetPayTransactionByOutTradeNumberResponse.Types.__zz__Promotion
                            {
                            }

                            public class Promotion : __zz__Promotion
                            {
                                public static class Types
                                {
                                    public class GoodsDetail : GetPayTransactionByOutTradeNumberResponse.Types.Promotion.Types.GoodsDetail
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置单品列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("goods_detail")]
                                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                                public List<Types.GoodsDetail>? GoodsList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置优惠信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_detail")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
                        public List<Types.Promotion>? PromotionList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置收款明细列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("details")]
                [System.Text.Json.Serialization.JsonPropertyName("details")]
                public List<Types.CollectionDetail>? DetailList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置商户服务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付服务单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置服务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_introduction")]
        [System.Text.Json.Serialization.JsonPropertyName("service_introduction")]
        public string? ServiceIntroduction { get; set; }

        /// <summary>
        /// 获取或设置服务订单状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// 获取或设置服务订单状态说明。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("state_description")]
        public string? StateDescription { get; set; }

        /// <summary>
        /// 获取或设置商户收款总金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置付费项目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_payments")]
        [System.Text.Json.Serialization.JsonPropertyName("post_payments")]
        public List<Types.PostPayment>? PostPaymentList { get; set; }

        /// <summary>
        /// 获取或设置商户优惠列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("post_discounts")]
        [System.Text.Json.Serialization.JsonPropertyName("post_discounts")]
        public List<Types.PostDiscount>? PostDiscountList { get; set; }

        /// <summary>
        /// 获取或设置服务时间段信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_range")]
        [System.Text.Json.Serialization.JsonPropertyName("time_range")]
        public Types.TimeRange? TimeRange { get; set; }

        /// <summary>
        /// 获取或设置服务位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("location")]
        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public Types.Location? Location { get; set; }

        /// <summary>
        /// 获取或设置订单风险金信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_fund")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_fund")]
        public Types.RiskFund? RiskFund { get; set; }

        /// <summary>
        /// 获取或设置通知回调地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置是否需要收款。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_collection")]
        [System.Text.Json.Serialization.JsonPropertyName("need_collection")]
        public bool? RequireCollection { get; set; }

        /// <summary>
        /// 获取或设置收款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("collection")]
        [System.Text.Json.Serialization.JsonPropertyName("collection")]
        public Types.Collection? Collection { get; set; }
    }
}
