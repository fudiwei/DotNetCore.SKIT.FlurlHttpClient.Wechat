namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/payments/app-registering-pay 接口的请求。</para>
    /// </summary>
    [WechatTenpayBusinessSensitive]
    public class CreatePaymentAppRegisteringPayRequest : WechatTenpayBusinessRequest
    {
        public static class Types
        {
            public class Payee : CreatePaymentAppPayRequest.Types.Payee
            {
            }

            public class Payer : CreatePaymentAppPayRequest.Types.Payer
            {
            }

            public class Goods : CreatePaymentAppPayRequest.Types.Goods
            {
            }

            public class NotifyConfig : CreatePaymentAppPayRequest.Types.__zz__NotifyConfig
            {
                public static class Types
                {
                    public class FrontendCallback : CreatePaymentAppPayRequest.Types.NotifyConfig.Types.FrontendCallback
                    {
                    }
                }

                /// <summary>
                /// 获取或设置前端回跳信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_callback_url")]
                [System.Text.Json.Serialization.JsonPropertyName("front_callback_url")]
                public Types.FrontendCallback? FrontendCallback { get; set; }
            }

            public class RiskControl : CreatePaymentAppPayRequest.Types.RiskControl
            {
            }

            public class Scene
            {
                public static class Types
                {
                    public class Store : CreatePaymentAppPayRequest.Types.Scene.Types.Store
                    {
                    }
                }

                /// <summary>
                /// 获取或设置门店信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_info")]
                [System.Text.Json.Serialization.JsonPropertyName("store_info")]
                public Types.Store? Store { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置付款类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purchaser_type")]
        [System.Text.Json.Serialization.JsonPropertyName("purchaser_type")]
        public string? PurchaserType { get; set; }

        /// <summary>
        /// 获取或设置平台支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_payment_id")]
        public string? OutPaymentId { get; set; }

        /// <summary>
        /// 获取或设置支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置币种。
        /// <para>默认值：CNY</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency")]
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string? Currency { get; set; } = "CNY";

        /// <summary>
        /// 获取或设置过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置收款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee")]
        [System.Text.Json.Serialization.JsonPropertyName("payee")]
        public Types.Payee? Payee { get; set; }

        /// <summary>
        /// 获取或设置付款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public Types.Payer? Payer { get; set; }

        /// <summary>
        /// 获取或设置附言。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        [System.Text.Json.Serialization.JsonPropertyName("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// 获取或设置商品信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods")]
        [System.Text.Json.Serialization.JsonPropertyName("goods")]
        public List<Types.Goods>? GoodsList { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachment")]
        [System.Text.Json.Serialization.JsonPropertyName("attachment")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置风控信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_control")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_control")]
        public Types.RiskControl? RiskControl { get; set; }

        /// <summary>
        /// 获取或设置回调配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public Types.NotifyConfig? NotifyConfig { get; set; }

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public Types.Scene? Scene { get; set; }

        /// <summary>
        /// 获取或设置分账标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profit_allocation_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("profit_allocation_flag")]
        public string? ProfitAllocationFlag { get; set; }
    }
}
