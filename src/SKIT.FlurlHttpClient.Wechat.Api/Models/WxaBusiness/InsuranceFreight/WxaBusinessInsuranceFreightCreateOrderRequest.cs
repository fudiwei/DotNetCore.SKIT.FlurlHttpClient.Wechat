namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/insurance_freight/createorder 接口的请求。</para>
    /// </summary>
    public class WxaBusinessInsuranceFreightCreateOrderRequest : WechatApiRequest, IInferable<WxaBusinessInsuranceFreightCreateOrderRequest, WxaBusinessInsuranceFreightCreateOrderResponse>
    {
        public static class Types
        {
            public class Address
            {
                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string Province { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string City { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("county")]
                [System.Text.Json.Serialization.JsonPropertyName("county")]
                public string District { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string DetailAddress { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置买家用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_no")]
        [System.Text.Json.Serialization.JsonPropertyName("order_no")]
        public string OrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_time")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
        public long PayTimestamp { get; set; }

        /// <summary>
        /// 获取或设置支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
        public int PayAmount { get; set; }

        /// <summary>
        /// 获取或设置发货运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_no")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_no")]
        public string DeliveryNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置发货地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_place")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_place")]
        public Types.Address DeliveryAddress { get; set; } = new Types.Address();

        /// <summary>
        /// 获取或设置收货地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt_place")]
        [System.Text.Json.Serialization.JsonPropertyName("receipt_place")]
        public Types.Address ReceiptAddress { get; set; } = new Types.Address();
    }
}
