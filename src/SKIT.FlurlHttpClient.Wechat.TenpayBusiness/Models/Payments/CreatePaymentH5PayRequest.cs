using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/payments/h5-pay 接口的请求。</para>
    /// </summary>
    [WechatTenpayBusinessSensitive]
    public class CreatePaymentH5PayRequest : CreatePaymentAppPayRequest
    {
        public static new class Types
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

            public class NotifyConfig : CreatePaymentAppPayRequest.Types.NotifyConfig
            {
                public static new class Types
                {
                    public class FrontendCallback
                    {
                        /// <summary>
                        /// 获取或设置 H5 回跳地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("h5_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("h5_url")]
                        public string H5Url { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置前端回跳信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_callback_url")]
                [System.Text.Json.Serialization.JsonPropertyName("front_callback_url")]
                public new Types.FrontendCallback? FrontendCallback { get; set; }
            }

            public class RiskControl : CreatePaymentAppPayRequest.Types.RiskControl
            {
            }

            public class Scene : CreatePaymentAppPayRequest.Types.Scene
            {
                public static new class Types
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
                public new Types.Store? Store { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置收款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee")]
        [System.Text.Json.Serialization.JsonPropertyName("payee")]
        public new Types.Payee Payee { get; set; } = new Types.Payee();

        /// <summary>
        /// 获取或设置付款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public new Types.Payer? Payer { get; set; }

        /// <summary>
        /// 获取或设置商品信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods")]
        [System.Text.Json.Serialization.JsonPropertyName("goods")]
        public new IList<Types.Goods>? GoodsList { get; set; }

        /// <summary>
        /// 获取或设置风控信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_control")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_control")]
        public new Types.RiskControl? RiskControl { get; set; }

        /// <summary>
        /// 获取或设置回调配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public new Types.NotifyConfig NotifyConfig { get; set; } = new Types.NotifyConfig();

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public new Types.Scene? Scene { get; set; }
    }
}
