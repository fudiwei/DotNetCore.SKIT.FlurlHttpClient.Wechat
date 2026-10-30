namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/no_worry_return/add 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliveryNoWorryReturnAddRequest : WechatApiRequest, IInferable<CgibinExpressDeliveryNoWorryReturnAddRequest, CgibinExpressDeliveryNoWorryReturnAddResponse>
    {
        public static class Types
        {
            public class Address
            {
                /// <summary>
                /// 获取或设置国家。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("country")]
                [System.Text.Json.Serialization.JsonPropertyName("country")]
                public string? Country { get; set; }

                /// <summary>
                /// 获取或设置省份。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("province")]
                [System.Text.Json.Serialization.JsonPropertyName("province")]
                public string? Province { get; set; }

                /// <summary>
                /// 获取或设置城市。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city")]
                [System.Text.Json.Serialization.JsonPropertyName("city")]
                public string? City { get; set; }

                /// <summary>
                /// 获取或设置区县。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("area")]
                [System.Text.Json.Serialization.JsonPropertyName("area")]
                public string? District { get; set; }

                /// <summary>
                /// 获取或设置详细地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Detail { get; set; }

                /// <summary>
                /// 获取或设置联系人。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }
            }

            public class Goods
            {
                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置商品图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("url")]
                [System.Text.Json.Serialization.JsonPropertyName("url")]
                public string? ImageUrl { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商家退货单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_order_id")]
        public string? ShopOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家退货地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_addr")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_addr")]
        public Types.Address? ShopAddress { get; set; }

        /// <summary>
        /// 获取或设置用户收货地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_addr")]
        [System.Text.Json.Serialization.JsonPropertyName("user_addr")]
        public Types.Address? UserAddress { get; set; }

        /// <summary>
        /// 获取或设置退货用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置订单中心页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_path")]
        [System.Text.Json.Serialization.JsonPropertyName("order_path")]
        public string? OrderPagePath { get; set; }

        /// <summary>
        /// 获取或设置退货商品列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_list")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_list")]
        public List<Types.Goods>? GoodsList { get; set; }

        /// <summary>
        /// 获取或设置退货订单价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_price")]
        [System.Text.Json.Serialization.JsonPropertyName("order_price")]
        public int? OrderPrice { get; set; }

        /// <summary>
        /// 获取或设置微信支付投保单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_pay_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_pay_id")]
        public string? WxpayId { get; set; }

        /// <summary>
        /// 获取或设置动态服务通知代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_code")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_code")]
        public string? NotifyCode { get; set; }
    }
}
