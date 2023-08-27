namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/query_order 接口的响应。</para>
    /// </summary>
    public class XPayQueryOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置虚拟支付环境。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env_type")]
                [System.Text.Json.Serialization.JsonPropertyName("env_type")]
                public int Environment { get; set; }

                /// <summary>
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置业务类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_type")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_type")]
                public int BusinessType { get; set; }

                /// <summary>
                /// 获取或设置订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("order_fee")]
                public int OrderFee { get; set; }

                /// <summary>
                /// 获取或设置订单优惠金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_fee")]
                public int CouponFee { get; set; }

                /// <summary>
                /// 获取或设置用户支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_fee")]
                public int PaidFee { get; set; }

                /// <summary>
                /// 获取或设置退款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_fee")]
                public int? RefundFee { get; set; }

                /// <summary>
                /// 获取或设置剩余金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("left_fee")]
                [System.Text.Json.Serialization.JsonPropertyName("left_fee")]
                public int? LeftFee { get; set; }

                /// <summary>
                /// 获取或设置付款时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_time")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_time")]
                public long? PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置发货时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("provide_time")]
                [System.Text.Json.Serialization.JsonPropertyName("provide_time")]
                public long? ProvideTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单创建时传的信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_meta")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_meta")]
                public string? BusinessMeta { get; set; }

                /// <summary>
                /// 获取或设置下单时米大师返回的 Token。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("token")]
                [System.Text.Json.Serialization.JsonPropertyName("token")]
                public string? MidasToken { get; set; }

                /// <summary>
                /// 获取或设置微信内部单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wx_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wx_order_id")]
                public string WxOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置渠道单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_order_id")]
                public string? ChannelOrderId { get; set; }

                /// <summary>
                /// 获取或设置微信支付交易单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxpay_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("wxpay_order_id")]
                public string? TransactionId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;
    }
}
