using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /abnormal-fund-processing/receipts/{receipt_id} 接口的响应。</para>
    /// </summary>
    public class GetAbnormalFundProcessingReceiptByReceiptIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Amount
            {
                /// <summary>
                /// 获取或设置付款金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total")]
                [System.Text.Json.Serialization.JsonPropertyName("total")]
                public int Total { get; set; }

                /// <summary>
                /// 获取或设置付款币种。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string? Currency { get; set; }
            }

            public class Instruction
            {
                public static class Types
                {
                    public class Commander
                    {
                        /// <summary>
                        /// 获取或设置发起付款请求的角色。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("operator")]
                        [System.Text.Json.Serialization.JsonPropertyName("operator")]
                        public string Operator { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置微信商户号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mchid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                        public string? MerchantId { get; set; }
                    }

                    public class Receiver
                    {
                        /// <summary>
                        /// 获取或设置入账账户类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("account_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                        public string? AccountType { get; set; }

                        /// <summary>
                        /// 获取或设置微信 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string? AppId { get; set; }

                        /// <summary>
                        /// 获取或设置用户 OpenId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("openid")]
                        [System.Text.Json.Serialization.JsonPropertyName("openid")]
                        public string? OpenId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置商户指令编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_instruction_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_instruction_no")]
                public string? OutInstructionNumber { get; set; }

                /// <summary>
                /// 获取或设置指令发起方信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commander")]
                [System.Text.Json.Serialization.JsonPropertyName("commander")]
                public Types.Commander Commander { get; set; } = default!;

                /// <summary>
                /// 获取或设置付款方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transfer_mode")]
                [System.Text.Json.Serialization.JsonPropertyName("transfer_mode")]
                public string TransferMode { get; set; } = default!;

                /// <summary>
                /// 获取或设置入账用户信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receiver")]
                [System.Text.Json.Serialization.JsonPropertyName("receiver")]
                public Types.Receiver? Receiver { get; set; }

                /// <summary>
                /// 获取或设置入账成功时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("success_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? SuccessTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置业务名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_name")]
        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
        public string ProductName { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付在途异常资金付款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt_id")]
        [System.Text.Json.Serialization.JsonPropertyName("receipt_id")]
        public string ReceiptId { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_amount")]
        public Types.Amount Amount { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款指令信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("instruction")]
        [System.Text.Json.Serialization.JsonPropertyName("instruction")]
        public Types.Instruction Instruction { get; set; } = default!;

        /// <summary>
        /// 获取或设置付款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt_state")]
        [System.Text.Json.Serialization.JsonPropertyName("receipt_state")]
        public string ReceiptState { get; set; } = default!;

        /// <summary>
        /// 获取或设置单据创建时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("create_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("create_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset CreateTime { get; set; }

        /// <summary>
        /// 获取或设置单据更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("last_update_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("last_update_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset UpdateTime { get; set; }
    }
}
