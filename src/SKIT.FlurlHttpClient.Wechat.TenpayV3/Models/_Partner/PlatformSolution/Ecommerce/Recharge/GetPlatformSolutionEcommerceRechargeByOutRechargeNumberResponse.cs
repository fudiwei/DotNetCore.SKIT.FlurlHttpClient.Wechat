using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /platsolution/ecommerce/recharges/out-recharge-no/{out_recharge_no} 接口的响应。</para>
    /// </summary>
    public class GetPlatformSolutionEcommerceRechargeByOutRechargeNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class RechargeAmount : GetBankTransferRechargeByOutRechargeNumberResponse.Types.RechargeAmount
            {
            }

            public class BankTransferInfo : GetBankTransferRechargeByOutRechargeNumberResponse.Types.BankTransferInfo
            {
            }

            public class QrRechargeInfo
            {
                /// <summary>
                /// 获取或设置用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string? OpenId { get; set; }

                /// <summary>
                /// 获取或设置员工类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("employee_type")]
                [System.Text.Json.Serialization.JsonPropertyName("employee_type")]
                public string? EmployeeType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_recharge_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_recharge_no")]
        public string OutRechargeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信充值单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_id")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_id")]
        public string RechargeId { get; set; } = default!;

        /// <summary>
        /// 获取或设置充值渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_channel")]
        public string? RechargeChannel { get; set; }

        /// <summary>
        /// 获取或设置充值场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_scene")]
        public string RechargeScene { get; set; } = default!;

        /// <summary>
        /// 获取或设置充值状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_state")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_state")]
        public string RechargeState { get; set; } = default!;

        /// <summary>
        /// 获取或设置充值状态描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_state_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_state_desc")]
        public string? RechargeSceneDescription { get; set; }

        /// <summary>
        /// 获取或设置充值入账账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = default!;

        /// <summary>
        /// 获取或设置充值金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recharge_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("recharge_amount")]
        public Types.RechargeAmount RechargeAmount { get; set; } = default!;

        /// <summary>
        /// 获取或设置转账充值的付款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_transfer_info")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_transfer_info")]
        public Types.BankTransferInfo? BankTransferInfo { get; set; }

        /// <summary>
        /// 获取或设置扫码充值的付款信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qr_recharge_info")]
        [System.Text.Json.Serialization.JsonPropertyName("qr_recharge_info")]
        public Types.QrRechargeInfo? QrRechargeInfo { get; set; }

        /// <summary>
        /// 获取或设置充值受理时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("accept_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? AcceptTime { get; set; }

        /// <summary>
        /// 获取或设置充值成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置充值关闭时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("close_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? CloseTime { get; set; }
    }
}
