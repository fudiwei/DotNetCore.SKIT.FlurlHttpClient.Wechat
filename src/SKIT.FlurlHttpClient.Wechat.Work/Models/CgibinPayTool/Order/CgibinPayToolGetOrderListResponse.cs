namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/paytool/get_order_list 接口的响应。</para>
    /// </summary>
    public class CgibinPayToolGetOrderListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置收款订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置客户企业 CorpId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_corpid")]
                public string? CustomCorpId { get; set; }

                /// <summary>
                /// 获取或设置创建订单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置购买内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buy_content")]
                [System.Text.Json.Serialization.JsonPropertyName("buy_content")]
                public string BuyContent { get; set; } = default!;

                /// <summary>
                /// 获取或设置原价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("origin_price")]
                [System.Text.Json.Serialization.JsonPropertyName("origin_price")]
                public int OriginPrice { get; set; }

                /// <summary>
                /// 获取或设置现价（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("paid_price")]
                [System.Text.Json.Serialization.JsonPropertyName("paid_price")]
                public int PaidPrice { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置订单来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_from")]
                [System.Text.Json.Serialization.JsonPropertyName("order_from")]
                public int OrderFrom { get; set; }

                /// <summary>
                /// 获取或设置订单创建人成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("creator")]
                [System.Text.Json.Serialization.JsonPropertyName("creator")]
                public string? CreatorUserId { get; set; }

                /// <summary>
                /// 获取或设置支付方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_type")]
                public int PayType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_order_list")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_order_list")]
        public Types.Order[] OrderList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasMore { get; set; }
    }
}
