namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/partner/transactions/app 接口的请求。</para>
    /// </summary>
    public class CreatePayPartnerTransactionAppRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Payer
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sp_openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置子商户用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                public string? SubOpenId { get; set; }
            }

            public class Amount : CreatePayTransactionAppRequest.Types.Amount
            {
            }

            public abstract class __zz__Detail : CreatePayTransactionAppRequest.Types.__zz__Detail
            {
            }

            public class Detail : __zz__Detail
            {
                public static class Types
                {
                    public class GoodsDetail : CreatePayTransactionAppRequest.Types.Detail.Types.GoodsDetail
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

            public abstract class __zz__Scene : CreatePayTransactionAppRequest.Types.__zz__Scene
            {
            }

            public class Scene : __zz__Scene
            {
                public static class Types
                {
                    public class Store : CreatePayTransactionAppRequest.Types.Scene.Types.Store
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商户门店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_info")]
                [System.Text.Json.Serialization.JsonPropertyName("store_info")]
                public Types.Store? Store { get; set; }
            }

            public class Settlement : CreatePayTransactionAppRequest.Types.Settlement
            {
            }

            public class Subsidy
            {
                public static class Types
                {
                    public abstract class __zz__SubsidyDetail : CreatePayTransactionAppRequest.Types.Subsidy.Types.__zz__SubsidyDetail
                    {
                    }

                    public class SubsidyDetail : __zz__SubsidyDetail
                    {
                        public static class Types
                        {
                            public class SubsidyPlan : CreatePayTransactionAppRequest.Types.Subsidy.Types.SubsidyDetail.Types.SubsidyPlan
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置还款计划列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subsidy_plan")]
                        [System.Text.Json.Serialization.JsonPropertyName("subsidy_plan")]
                        public List<Types.SubsidyPlan>? SubsidyPlanList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置贴息详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subsidy_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("subsidy_detail")]
                public List<Types.SubsidyDetail>? SubsidyDetailList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置子商户微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置商品描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string? OutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置订单优惠标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_tag")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
        public string? GoodsTag { get; set; }

        /// <summary>
        /// 获取或设置是否支持开票。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_fapiao")]
        [System.Text.Json.Serialization.JsonPropertyName("support_fapiao")]
        public bool? IsSupportFapiao { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer? Payer { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount? Amount { get; set; }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail")]
        [System.Text.Json.Serialization.JsonPropertyName("detail")]
        public Types.Detail? Detail { get; set; }

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene? Scene { get; set; }

        /// <summary>
        /// 获取或设置结算信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settle_info")]
        [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
        public Types.Settlement? Settlement { get; set; }

        /// <summary>
        /// 获取或设置贴息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsidy_info")]
        [System.Text.Json.Serialization.JsonPropertyName("subsidy_info")]
        public Types.Subsidy? Subsidy { get; set; }
    }
}
