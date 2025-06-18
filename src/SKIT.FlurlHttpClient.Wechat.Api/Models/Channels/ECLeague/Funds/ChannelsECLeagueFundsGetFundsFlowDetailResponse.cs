using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/funds/getfundsflowdetail 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueFundsGetFundsFlowDetailResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FundsFlow
            {
                public static class Types
                {
                    public class RelatedInfo
                    {
                        /// <summary>
                        /// 获取或设置关联类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("related_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("related_type")]
                        public string RelatedType { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置订单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("order_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string? OrderId { get; set; }

                        /// <summary>
                        /// 获取或设置售后单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("aftersale_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string? AftersaleOrderId { get; set; }

                        /// <summary>
                        /// 获取或设置支付单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                        public string? TransactionId { get; set; }

                        /// <summary>
                        /// 获取或设置提现单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("withdraw_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("withdraw_id")]
                        public string? WithdrawId { get; set; }

                        /// <summary>
                        /// 获取或设置运费险单号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("insurance_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("insurance_id")]
                        public string? InsuranceId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置资金流水单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow_id")]
                [System.Text.Json.Serialization.JsonPropertyName("flow_id")]
                public string FundsFlowId { get; set; } = default!;

                /// <summary>
                /// 获取或设置资金类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("funds_type")]
                [System.Text.Json.Serialization.JsonPropertyName("funds_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int FundsType { get; set; }

                /// <summary>
                /// 获取或设置流水类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow_type")]
                [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int FlowType { get; set; }

                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Balance { get; set; }

                /// <summary>
                /// 获取或设置流水关联信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("related_info_list")]
                [System.Text.Json.Serialization.JsonPropertyName("related_info_list")]
                public Types.RelatedInfo[] RelatedInfoList { get; set; } = default!;

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置记账时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bookkeeping_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.BasicDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("bookkeeping_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.BasicDateTimeOffsetConverter))]
                public DateTimeOffset BookkeepingTIme { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置资金流水信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("funds_flow")]
        [System.Text.Json.Serialization.JsonPropertyName("funds_flow")]
        public Types.FundsFlow FundsFlow { get; set; } = default!;
    }
}
