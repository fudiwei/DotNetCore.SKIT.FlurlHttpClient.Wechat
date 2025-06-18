namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/license/get_union_order 接口的响应。</para>
    /// </summary>
    public class CgibinLicenseGetUnionOrderResponse : WechatWorkResponse
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
                /// 获取或设置订单类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_type")]
                [System.Text.Json.Serialization.JsonPropertyName("order_type")]
                public int OrderType { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置订单金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("price")]
                [System.Text.Json.Serialization.JsonPropertyName("price")]
                public int Price { get; set; }

                /// <summary>
                /// 获取或设置下单时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_time")]
                public long? PayTimestamp { get; set; }
            }

            public class Buy
            {
                public static class Types
                {
                    public class AccountCount : CgibinLicenseGetOrderResponse.Types.Order.Types.AccountCount
                    {
                    }

                    public class AccountDuration : CgibinLicenseGetOrderResponse.Types.Order.Types.AccountDuration
                    {
                    }
                }

                /// <summary>
                /// 获取或设置子订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_order_id")]
                public string SubOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置企业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("corpid")]
                [System.Text.Json.Serialization.JsonPropertyName("corpid")]
                public string CorpId { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号个数信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_count")]
                [System.Text.Json.Serialization.JsonPropertyName("account_count")]
                public Types.AccountCount AccountCount { get; set; } = default!;

                /// <summary>
                /// 获取或设置账号时长信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("account_duration")]
                public Types.AccountDuration AccountDuration { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public Types.Order Order { get; set; } = default!;

        /// <summary>
        /// 获取或设置多企业购买信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("buy_list")]
        [System.Text.Json.Serialization.JsonPropertyName("buy_list")]
        public Types.Buy[] BuyList { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否还有更多数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("has_more")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool HasMore { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
