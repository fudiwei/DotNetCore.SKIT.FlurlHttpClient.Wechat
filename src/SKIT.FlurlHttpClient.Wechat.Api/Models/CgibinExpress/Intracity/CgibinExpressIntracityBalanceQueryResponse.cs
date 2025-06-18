namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/balancequery 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityBalanceQueryResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BalanceDetail
            {
                public static class Types
                {
                    public class Order
                    {
                        /// <summary>
                        /// 获取或设置充值订单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("payorder_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("payorder_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string PayOrderId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置充值金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("charge_amt")]
                        [System.Text.Json.Serialization.JsonPropertyName("charge_amt")]
                        public int ChargeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置未使用的余额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("unused_amt")]
                        [System.Text.Json.Serialization.JsonPropertyName("unused_amt")]
                        public int UnusedAmount { get; set; }

                        /// <summary>
                        /// 获取或设置充值生效时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("begin_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                        public long BeginTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置充值失效时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long EndTimestamp { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                public int Balance { get; set; }

                /// <summary>
                /// 获取或设置运力 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_trans_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
                public string ServiceTransId { get; set; } = default!;

                /// <summary>
                /// 获取或设置运力名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_trans_name")]
                [System.Text.Json.Serialization.JsonPropertyName("service_trans_name")]
                public string ServiceTransName { get; set; } = default!;

                /// <summary>
                /// 获取或设置充值订单列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_list")]
                [System.Text.Json.Serialization.JsonPropertyName("order_list")]
                public Types.Order[]? OrderList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_store_id")]
        public string StoreId { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置总余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("all_balance")]
        [System.Text.Json.Serialization.JsonPropertyName("all_balance")]
        public int TotalBalance { get; set; }

        /// <summary>
        /// 获取或设置余额详情列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("balance_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("balance_detail")]
        public Types.BalanceDetail[] BalanceDetailList { get; set; } = default!;
    }
}
