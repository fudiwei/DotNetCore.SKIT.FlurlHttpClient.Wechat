namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /combine-transactions/app 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreateCombineTransactionAppRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public abstract class __zz__SubOrder
            {
                /// <summary>
                /// 获取或设置子单微信商户号。如果不指定将使用合单微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string? MerchantId { get; set; }

                /// <summary>
                /// 获取或设置子单子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string? SubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置子单子商户微信 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
                public string? SubAppId { get; set; }

                /// <summary>
                /// 获取或设置商品服务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_service_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_service_type")]
                public string? OrderServiceType { get; set; }

                /// <summary>
                /// 获取或设置个人收款方受理授权 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("individual_auth_id")]
                [System.Text.Json.Serialization.JsonPropertyName("individual_auth_id")]
                public string? IndividualAuthId { get; set; }

                /// <summary>
                /// 获取或设置个人收款方平台昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("individual_name")]
                [System.Text.Json.Serialization.JsonPropertyName("individual_name")]
                public string? IndividualName { get; set; }

                /// <summary>
                /// 获取或设置附加数据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("attach")]
                [System.Text.Json.Serialization.JsonPropertyName("attach")]
                public string? Attachment { get; set; }

                /// <summary>
                /// 获取或设置商品描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string? Description { get; set; }

                /// <summary>
                /// 获取或设置子单商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string? OutTradeNumber { get; set; }

                /// <summary>
                /// 获取或设置订单优惠标记。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_tag")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_tag")]
                public string? GoodsTag { get; set; }
            }

            public class SubOrder : __zz__SubOrder
            {
                public static class Types
                {
                    public class Amount : CreatePayTransactionAppRequest.Types.Amount
                    {
                        /// <summary>
                        /// 获取或设置标价金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("total_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("total_amount")]
                        public new int Total
                        {
                            get { return base.Total; }
                            set { base.Total = value; }
                        }
                    }

                    public class Settlement : CreatePayTransactionAppRequest.Types.Settlement
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

            public abstract class __zz__Payer : CreatePayTransactionAppRequest.Types.Payer
            {
                /// <summary>
                /// 获取或设置子商户用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_openid")]
                public string? SubOpenId { get; set; }
            }

            public class Payer : __zz__Payer
            {
                public static class Types
                {
                    public class Identity
                    {
                        /// <summary>
                        /// 获取或设置证件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public string? IdentityType { get; set; }

                        /// <summary>
                        /// 获取或设置证件姓名。
                        /// </summary>
                        /// <remarks>
                        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
                        /// </remarks>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? IdName { get; set; }

                        /// <summary>
                        /// 获取或设置证件号码。
                        /// </summary>
                        /// <remarks>
                        /// 该属性是敏感数据字段，需要使用平台公钥或证书加密。
                        /// </remarks>
                        [Newtonsoft.Json.JsonProperty("number")]
                        [System.Text.Json.Serialization.JsonPropertyName("number")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? IdNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置实名支付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                public Types.Identity? Identity { get; set; }
            }

            public class Scene
            {
                /// <summary>
                /// 获取或设置用户终端 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_client_ip")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_client_ip")]
                public string? ClientIp { get; set; }

                /// <summary>
                /// 获取或设置商户端设备号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }
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
