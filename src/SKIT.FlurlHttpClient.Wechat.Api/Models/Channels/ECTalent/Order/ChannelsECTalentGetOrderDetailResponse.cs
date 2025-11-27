namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/talent/get_order_detail 接口的响应。</para>
    /// </summary>
    public class ChannelsECTalentGetOrderDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BaseInfo
            {
                public static class Types
                {
                    public class BuyerInfo
                    {
                        /// <summary>
                        /// 获取或设置用户 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("open_id")]
                        public string OpenId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置用户 UnionId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("union_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("union_id")]
                        public string? UnionId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置佣金单特殊标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("special_id")]
                [System.Text.Json.Serialization.JsonPropertyName("special_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string? SpecialId { get; set; }

                /// <summary>
                /// 获取或设置 SPU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("spu_id")]
                [System.Text.Json.Serialization.JsonPropertyName("spu_id")]
                public string SPUId { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public long SKUId { get; set; }

                /// <summary>
                /// 获取或设置订单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_status")]
                [System.Text.Json.Serialization.JsonPropertyName("order_status")]
                public int OrderStatus { get; set; }

                /// <summary>
                /// 获取或设置实际支付金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_payment")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_payment")]
                public string ActualPayment { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单支付时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_pay_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_pay_time")]
                public long OrderPayTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_create_time")]
                public long OrderCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置订单更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_update_time")]
                public long OrderUpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置买家信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("buyer_info")]
                [System.Text.Json.Serialization.JsonPropertyName("buyer_info")]
                public Types.BuyerInfo BuyerInfo { get; set; } = default!;
            }

            public class CommissionInfo
            {
                /// <summary>
                /// 获取或设置佣金单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置佣金费率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ratio")]
                [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                public string Ratio { get; set; } = default!;

                /// <summary>
                /// 获取或设置预计结算时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expect_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("expect_settle_time")]
                public long ExpectedSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置预计结算金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expect_settlement")]
                [System.Text.Json.Serialization.JsonPropertyName("expect_settlement")]
                public string ExpectedSettlementString { get; set; } = default!;

                /// <summary>
                /// 获取或设置实际结算时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_settle_time")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_settle_time")]
                public long? ActualSettleTimestamp { get; set; }

                /// <summary>
                /// 获取或设置实际结算金额（单位：元）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actual_settlement")]
                [System.Text.Json.Serialization.JsonPropertyName("actual_settlement")]
                public string? ActualSettlementString { get; set; }
            }

            public class ChannelInfo
            {
                /// <summary>
                /// 获取或设置渠道类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_type")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
                public int ChannelType { get; set; }

                /// <summary>
                /// 获取或设置渠道 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_id")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置渠道名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("channel_name")]
                [System.Text.Json.Serialization.JsonPropertyName("channel_name")]
                public string Name { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置基础信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_info")]
        [System.Text.Json.Serialization.JsonPropertyName("base_info")]
        public Types.BaseInfo BaseInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置佣金信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commission_info")]
        [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
        public Types.CommissionInfo CommissionInfo { get; set; } = default!;

        /// <summary>
        /// 获取或设置视频号信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_info")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_info")]
        public Types.ChannelInfo ChannelInfo { get; set; } = default!;
    }
}
