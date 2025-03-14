using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 REFUND.SUCCESS （仅限直连商户）通知的数据。</para>
    /// <para>表示 REFUND.ABNORMAL （仅限直连商户）通知的数据。</para>
    /// <para>表示 REFUND.CLOSED （仅限直连商户）通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791865 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4013080237 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012810605 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791886 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012791906 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012085921 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4013071196 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012587976 ]]> <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012083103 ]]>
    /// </para>
    /// </summary>
    public class RefundResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        public static class Types
        {
            public class Amount : Models.GetRefundDomesticRefundByOutRefundNumberResponse.Types.Amount
            {
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_trade_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
        public string OutTradeNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string OutRefundNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付退款号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_status")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_status")]
        public string RefundStatus { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款入账账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_received_account")]
        [System.Text.Json.Serialization.JsonPropertyName("user_received_account")]
        public string UserReceivedAccount { get; set; } = default!;

        /// <summary>
        /// 获取或设置退款成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("success_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("success_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
        public DateTimeOffset? SuccessTime { get; set; }

        /// <summary>
        /// 获取或设置退款金额信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public Types.Amount Amount { get; set; } = default!;
    }
}
