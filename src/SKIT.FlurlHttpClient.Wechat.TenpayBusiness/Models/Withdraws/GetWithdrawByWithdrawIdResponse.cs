using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [GET] /mse-pay/withdraws/{withdraw_id} 接口的响应。</para>
    /// </summary>
    public class GetWithdrawByWithdrawIdResponse : WechatTenpayBusinessResponse
    {
        public static class Types
        {
            public class Failure : GetProfitAllocationReceiverAccountApplicationByApplicationIdResponse.Types.Failure
            {
            }
        }

        /// <summary>
        /// 获取或设置平台提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_withdraw_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_withdraw_id")]
        public string OutWithdrawId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微企付提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_id")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_id")]
        public string WithdrawId { get; set; } = default!;

        /// <summary>
        /// 获取或设置提现金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置提现状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = default!;

        /// <summary>
        /// 获取或设置分账成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("succeeded_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("succeeded_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SucceedTime { get; set; }

        /// <summary>
        /// 获取或设置失败信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("failed_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("failed_reason")]
        public Types.Failure? Failure { get; set; }
    }
}
