namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 PAYSCORE.USER_CONFIRM（针对从业机构）回调通知事件的数据。</para>
    /// <para>表示 PAYSCORE.USER_PAID（针对从业机构）回调通知事件的数据。</para>
    /// </summary>
    public class PayScoreAcquiringBankServiceOrderResource : WechatTenpayEvent.Meta.IDecryptedResource
    {
        public static class Types
        {
            public class PostPayment : PayScoreServiceOrderResource.Types.PostPayment
            {
            }

            public class PostDiscount : PayScoreServiceOrderResource.Types.PostDiscount
            {
            }

            public class TimeRange : PayScoreServiceOrderResource.Types.TimeRange
            {
            }

            public class Location : PayScoreServiceOrderResource.Types.Location
            {
            }

            public class RiskFund : PayScoreServiceOrderResource.Types.RiskFund
            {
            }

            public class Collection : PayScoreServiceOrderResource.Types.__zz__Collection
            {
                public static class Types
                {
                    public class CollectionDetail : PayScoreServiceOrderResource.Types.Collection.Types.__zz__CollectionDetail
                    {
                        public static class Types
                        {
                            public class Promotion : PayScoreServiceOrderResource.Types.Collection.Types.CollectionDetail.Types.__zz__Promotion
                            {
                                public static class Types
                                {
                                    public class GoodsDetail : PayScoreServiceOrderResource.Types.Collection.Types.CollectionDetail.Types.Promotion.Types.GoodsDetail
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
        /// 获取或设置渠道商商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商户服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_order_no")]
        public string? OutOrderNumber { get; set; }

        /// <summary>
        /// 获取或设置微信支付服务订单号。
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
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置子商户用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
        public string? SubOpenId { get; set; }

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
