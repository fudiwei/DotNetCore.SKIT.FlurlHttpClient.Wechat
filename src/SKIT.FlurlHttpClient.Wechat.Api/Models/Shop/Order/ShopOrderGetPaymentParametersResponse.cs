namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/getpaymentparams 接口的响应。</para>
    /// </summary>
    public class ShopOrderGetPaymentParametersResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PaymentParameters
            {
                /// <summary>
                /// 获取或设置时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("timeStamp")]
                [System.Text.Json.Serialization.JsonPropertyName("timeStamp")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置随机字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nonceStr")]
                [System.Text.Json.Serialization.JsonPropertyName("nonceStr")]
                public string Nonce { get; set; } = default!;

                /// <summary>
                /// 获取或设置下单参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package")]
                [System.Text.Json.Serialization.JsonPropertyName("package")]
                public string Package { get; set; } = default!;

                /// <summary>
                /// 获取或设置签名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paySign")]
                [System.Text.Json.Serialization.JsonPropertyName("paySign")]
                public string PaySign { get; set; } = default!;

                /// <summary>
                /// 获取或设置签名方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("signType")]
                [System.Text.Json.Serialization.JsonPropertyName("signType")]
                public string SignType { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置支付参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_params")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_params")]
        public Types.PaymentParameters PaymentParameters { get; set; } = default!;
    }
}
