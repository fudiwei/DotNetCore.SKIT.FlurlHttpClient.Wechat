using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch_operate/risk/withdrawl-apply/out-request-no/{out_request_no} 接口的响应。</para>
    /// </summary>
    public class GetMerchantOperateRiskWithdrawlApplyByOutRequestNumberResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class WithdrawApplyment
            {
                /// <summary>
                /// 获取或设置商户提现申请单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
                public string OutRequestNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置提现申请单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("applyment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("applyment_id")]
                public string ApplymentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请单状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string State { get; set; } = default!;

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fail_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
                public string? FailReason { get; set; }

                /// <summary>
                /// 获取或设置最后更新时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? ModifyTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置提现申请单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdrawl_apply")]
        [System.Text.Json.Serialization.JsonPropertyName("withdrawl_apply")]
        public Types.WithdrawApplyment WithdrawApplyment { get; set; } = default!;
    }
}
