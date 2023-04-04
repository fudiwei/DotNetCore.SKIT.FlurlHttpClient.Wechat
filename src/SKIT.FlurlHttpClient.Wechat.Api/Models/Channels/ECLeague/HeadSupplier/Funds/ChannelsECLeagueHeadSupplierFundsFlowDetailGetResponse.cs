using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/funds/flowdetail/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierFundsFlowDetailGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class FundsFlow
            {
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
                public int FundsType { get; set; }

                /// <summary>
                /// 获取或设置流水类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("flow_type")]
                [System.Text.Json.Serialization.JsonPropertyName("flow_type")]
                public int FlowType { get; set; }

                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("balance")]
                [System.Text.Json.Serialization.JsonPropertyName("balance")]
                public int Balance { get; set; }

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
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("bookkeeping_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset BookkeepingTIme { get; set; }

                /// <summary>
                /// 获取或设置关联订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringReadOnlyConverter))]
                public string? OrderId { get; set; }

                /// <summary>
                /// 获取或设置关联提现单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("withdraw_id")]
                [System.Text.Json.Serialization.JsonPropertyName("withdraw_id")]
                public string? WithdrawId { get; set; }
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
