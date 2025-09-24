using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /ecommerce/account/apply-cancel-withdraw/out-request-no/{out_request_no} 接口的响应。</para>
    /// </summary>
    public class GetEcommerceAccountCancelWithdrawApplicationByOutRequestNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class WithdrawResult
            {
                /// <summary>
                /// 获取或设置出款子账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("out_account_type")]
                public string OutAccountType { get; set; } = default!;

                /// <summary>
                /// 获取或设置付款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_state")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_state")]
                public string PayState { get; set; } = default!;

                /// <summary>
                /// 获取或设置付款状态描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state_description")]
                [System.Text.Json.Serialization.JsonPropertyName("state_description")]
                public string PayStateDescription { get; set; } = default!;
            }

            public class Account
            {
                /// <summary>
                /// 获取或设置出款子账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("out_account_type")]
                public string OutAccountType { get; set; } = default!;

                /// <summary>
                /// 获取或设置账户金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int? Amount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付注销提现申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("applyment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户注销申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置注销状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_state")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_state")]
        public string CancelState { get; set; } = default!;

        /// <summary>
        /// 获取或设置注销状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cancel_state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("cancel_state_description")]
        public string CancelStateDescription { get; set; } = default!;

        /// <summary>
        /// 获取或设置提取资金类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw")]
        public string? WithdrawType { get; set; }

        /// <summary>
        /// 获取或设置提现状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_state")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_state")]
        public string? WithdrawState { get; set; }

        /// <summary>
        /// 获取或设置提现状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_state_description")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_state_description")]
        public string? WithdrawStateDescription { get; set; }

        /// <summary>
        /// 获取或设置提现结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_withdraw_result")]
        [System.Text.Json.Serialization.JsonPropertyName("account_withdraw_result")]
        public Types.WithdrawResult[]? WithdrawResultList { get; set; }

        /// <summary>
        /// 获取或设置更新时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? ModifyTime { get; set; }

        /// <summary>
        /// 获取或设置账户信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_info")]
        [System.Text.Json.Serialization.JsonPropertyName("account_info")]
        public Types.Account[]? AccountList { get; set; }
    }
}
