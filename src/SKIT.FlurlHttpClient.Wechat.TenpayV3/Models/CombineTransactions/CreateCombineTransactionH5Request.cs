namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /combine-transactions/h5 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateCombineTransactionH5Request : WechatTenpayRequest
    {
        public static class Types
        {
            public class SubOrder : CreateCombineTransactionAppRequest.Types.__zz__SubOrder
            {
                public static class Types
                {
                    public class Amount : CreateCombineTransactionAppRequest.Types.SubOrder.Types.Amount
                    {
                    }

                    public class Settlement : CreateCombineTransactionAppRequest.Types.SubOrder.Types.Settlement
                    {
                    }
                }

                /// <summary>
                /// 获取或设置金额信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public Types.Amount? Amount { get; set; }

                /// <summary>
                /// 获取或设置结算信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("settle_info")]
                [System.Text.Json.Serialization.JsonPropertyName("settle_info")]
                public Types.Settlement? Settlement { get; set; }
            }

            public class Payer : CreateCombineTransactionAppRequest.Types.__zz__Payer
            {
                public static class Types
                {
                    public class Identity : CreateCombineTransactionAppRequest.Types.Payer.Types.Identity
                    {
                    }
                }

                /// <summary>
                /// 获取或设置实名支付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                public Types.Identity? Identity { get; set; }
            }

            public class Scene : CreateCombineTransactionAppRequest.Types.Scene
            {
                public static class Types
                {
                    public class H5Info : CreatePayTransactionH5Request.Types.Scene.Types.H5Info
                    {
                    }
                }

                /// <summary>
                /// 获取或设置 H5 场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("h5_info")]
                [System.Text.Json.Serialization.JsonPropertyName("h5_info")]
                public Types.H5Info? H5Info { get; set; }
            }

            public class Subsidy
            {
                public static class Types
                {
                    public abstract class __zz__SubsidyDetail : CreateCombineTransactionAppRequest.Types.Subsidy.Types.__zz__SubsidyDetail
                    {
                    }

                    public class SubsidyDetail : __zz__SubsidyDetail
                    {
                        public static class Types
                        {
                            public class SubsidyPlan : CreateCombineTransactionAppRequest.Types.Subsidy.Types.SubsidyDetail.Types.SubsidyPlan
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
        /// 获取或设置合单发起方的微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_appid")]
        public string? CombineAppId { get; set; }

        /// <summary>
        /// 获取或设置合单发起方的微信商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_mchid")]
        public string? CombineMerchantId { get; set; }

        /// <summary>
        /// 获取或设置合单商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_out_trade_no")]
        public string? CombineOutTradeNumber { get; set; }

        /// <summary>
        /// 获取或设置交易起始时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_start")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_start")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// 获取或设置交易结束时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time_expire")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("time_expire")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset? ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置回调通知地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public string? NotifyUrl { get; set; }

        /// <summary>
        /// 获取或设置子单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_orders")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_orders")]
        public List<Types.SubOrder>? SubOrderList { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("combine_payer_info")]
        [System.Text.Json.Serialization.JsonPropertyName("combine_payer_info")]
        public Types.Payer? CombinePayer { get; set; }

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene? Scene { get; set; }

        /// <summary>
        /// 获取或设置贴息信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subsidy_info")]
        [System.Text.Json.Serialization.JsonPropertyName("subsidy_info")]
        public Types.Subsidy? Subsidy { get; set; }

        /// <summary>
        /// 获取或设置交易场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scenario")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scenario")]
        public string? TradeScenario { get; set; }
    }
}
