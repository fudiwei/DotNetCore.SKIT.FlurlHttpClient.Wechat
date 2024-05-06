namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global.Models
{
    /// <summary>
    /// <para>表示 [GET] /papay/transactions/out-trade-no/{out_trade_no} 接口的响应。</para>
    /// </summary>
    public class GetPartnerPAPPayTransactionByOutTradeNumberResponse : GetPAPPayTransactionByOutTradeNumberResponse
    {
        public static new class Types
        {
            public class Payer : GetPartnerTransactionByOutTradeNumberResponse.Types.Payer
            {
            }

            public class Amount : GetPartnerTransactionByOutTradeNumberResponse.Types.Amount
            {
                public static new class Types
                {
                    public class ExchangeRate : GetPartnerTransactionByOutTradeNumberResponse.Types.Amount.Types.ExchangeRate
                    {
                    }
                }

                /// <summary>
                /// 获取或设置汇率信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exchange_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("exchange_rate")]
                public new Types.ExchangeRate? ExchangeRate { get; set; }
            }

            public class Scene
            {
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

            public class Promotion : GetPartnerTransactionByOutTradeNumberResponse.Types.Promotion
            {
                public static new class Types
                {
                    public class GoodsDetail : GetPartnerTransactionByOutTradeNumberResponse.Types.Promotion.Types.GoodsDetail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置微信出资（单位：指定货币的最小单位）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxpay_contribute_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("wxpay_contribute_amount")]
                public new int? WechatpayContribute { get; set; }

                /// <summary>
                /// 获取或设置单品列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_detail")]
                public new Types.GoodsDetail[]? GoodsList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public override string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public override string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置子商户 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
        public string? SubAppId { get; set; }

        /// <summary>
        /// 获取或设置支付者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer")]
        [System.Text.Json.Serialization.JsonPropertyName("payer")]
        public new Types.Payer? Payer { get; set; }

        /// <summary>
        /// 获取或设置金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public new Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置场景信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_info")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_info")]
        public new Types.Scene? Scene { get; set; }

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public new Types.Promotion[]? PromotionList { get; set; }
    }
}
