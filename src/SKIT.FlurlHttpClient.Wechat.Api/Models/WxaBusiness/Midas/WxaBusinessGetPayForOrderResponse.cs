namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/getpayfororder 接口的响应。</para>
    /// </summary>
    public class WxaBusinessGetPayForOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PayForOrder
            {
                /// <summary>
                /// 获取或设置微信索要单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_no")]
                [System.Text.Json.Serialization.JsonPropertyName("order_no")]
                public string OrderNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置游戏业务单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string OutTradeNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单玩家 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置米大师发货分区。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("zone_id")]
                [System.Text.Json.Serialization.JsonPropertyName("zone_id")]
                public string MidasZoneId { get; set; } = default!;

                /// <summary>
                /// 获取或设置米大师环境。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env")]
                [System.Text.Json.Serialization.JsonPropertyName("env")]
                public int MidasEnvironment { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置索要单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payfororder")]
        [System.Text.Json.Serialization.JsonPropertyName("payfororder")]
        public Types.PayForOrder PayForOrder { get; set; } = default!;
    }
}
