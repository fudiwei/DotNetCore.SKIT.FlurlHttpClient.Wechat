namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /pay/transactions/app 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class CreatePayTransactionAppRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public abstract class __zz__Payer
            {
                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }
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

                        /// <summary>
                        /// 获取或设置是否加密证件信息。
                        /// <para>默认值：true</para>
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_encrypted")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_encrypted")]
                        public bool? IsEncrypted { get; set; } = true;
                    }
                }

                /// <summary>
                /// 获取或设置实名支付信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("identity")]
                [System.Text.Json.Serialization.JsonPropertyName("identity")]
                public Types.Identity? Identity { get; set; }
            }

            public class Amount
            {
                /// <summary>
                /// 获取或设置总金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置币种。
                /// <para>默认值："CNY"</para>
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; } = "CNY";
            }

            public abstract class __zz__Detail
            {
                /// <summary>
                /// 获取或设置订单原价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cost_price")]
                [System.Text.Json.Serialization.JsonPropertyName("cost_price")]
                public int? CostPrice { get; set; }

                /// <summary>
                /// 获取或设置商品小票 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("invoice_id")]
                [System.Text.Json.Serialization.JsonPropertyName("invoice_id")]
                public string? InvoiceId { get; set; }
            }

            public class Detail : __zz__Detail
            {
                public static class Types
                {
                    public class GoodsDetail
                    {
                        /// <summary>
                        /// 获取或设置商户侧商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_goods_id")]
                        public string? MerchantGoodsId { get; set; }

                        /// <summary>
                        /// 获取或设置微信侧商品编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wechatpay_goods_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("wechatpay_goods_id")]
                        public string? WechatpayGoodsId { get; set; }

                        /// <summary>
                        /// 获取或设置商品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("goods_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                        public string? GoodsName { get; set; }

                        /// <summary>
                        /// 获取或设置商品数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }

                        /// <summary>
                        /// 获取或设置商品单价（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unit_price")]
                        [System.Text.Json.Serialization.JsonPropertyName("unit_price")]
                        public int UnitPrice { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置单品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public List<Types.GoodsDetail>? GoodsList { get; set; }
            }

            public abstract class __zz__Scene
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

                /// <summary>
                /// 获取或设置商户端设备 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_ip")]
                [System.Text.Json.Serialization.JsonPropertyName("device_ip")]
                public string? DeviceIp { get; set; }
            }

            public class Scene : __zz__Scene
            {
                public static class Types
                {
                    public class Store
                    {
                        /// <summary>
                        /// 获取或设置门店编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string? Id { get; set; }

                        /// <summary>
                        /// 获取或设置商家自定义编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("out_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("out_id")]
                        public string? OutId { get; set; }

                        /// <summary>
                        /// 获取或设置门店名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置地区编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("area_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("area_code")]
                        public string? AreaCode { get; set; }

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string? Address { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商户门店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_info")]
                [System.Text.Json.Serialization.JsonPropertyName("store_info")]
                public Types.Store? Store { get; set; }
            }

            public class Settlement
            {
                /// <summary>
                /// 获取或设置是否分账。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("profit_sharing")]
                [System.Text.Json.Serialization.JsonPropertyName("profit_sharing")]
                public bool? IsProfitSharing { get; set; }

                /// <summary>
                /// 获取或设置补差金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subsidy_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("subsidy_amount")]
                public int? SubsidyAmount { get; set; }
            }

            public class Subsidy
            {
                public static class Types
                {
                    public abstract class __zz__SubsidyDetail
                    {
                        /// <summary>
                        /// 获取或设置还款类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subsidy_period_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("subsidy_period_type")]
                        public string? SubsidyPeriodType { get; set; }
                    }

                    public class SubsidyDetail : __zz__SubsidyDetail
                    {
                        public static class Types
                        {
                            public class SubsidyPlan
                            {
                                /// <summary>
                                /// 获取或设置贴息期数。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("subsidy_installment_num")]
                                [System.Text.Json.Serialization.JsonPropertyName("subsidy_installment_num")]
                                public int SubsidyInstallmentNumber { get; set; }

                                /// <summary>
                                /// 获取或设置贴息百分比。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("subsidy_percent")]
                                [System.Text.Json.Serialization.JsonPropertyName("subsidy_percent")]
                                public int SubsidyPercent { get; set; }
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
