using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/get_payment_result 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolGetPaymentResultResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class PaymentResult
            {
                /// <summary>
                /// 获取或设置学生账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("student_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("student_userid")]
                public string StudentUserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置家长账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_parent_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_parent_userid")]
                public string? ParentUserId { get; set; }

                /// <summary>
                /// 获取或设置付款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_state")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_state")]
                public int TradeState { get; set; }

                /// <summary>
                /// 获取或设置订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_no")]
                public string TradeNumber { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置收款项目名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("project_name")]
        [System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string ProjectName { get; set; } = default!;

        /// <summary>
        /// 获取或设置收款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置付款结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payment_result")]
        [System.Text.Json.Serialization.JsonPropertyName("payment_result")]
        public Types.PaymentResult[] PaymentResultList { get; set; } = default!;
    }
}
