namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Events
{
    /// <summary>
    /// <para>表示 withdraw.succeeded 通知的数据。</para>
    /// </summary>
    public class WithdrawEvent : WechatTenpayBusinessEvent<RefundEvent.Types.EventContent>
    {
        public static class Types
        {
            public class EventContent
            {
                /// <summary>
                /// 获取或设置微企付支付单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_id")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_id")]
                public string PaymentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置平台提现单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_withdraw_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_withdraw_id")]
                public string OutWithdrawId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置微企付提现单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("withdraw_id")]
                [System.Text.Json.Serialization.JsonPropertyName("withdraw_id")]
                public string WithdrawId { get; set; } = string.Empty;

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
            }
        }
    }
}
