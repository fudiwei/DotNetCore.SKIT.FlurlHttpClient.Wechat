namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/funds/scanwithdraw 接口的响应。</para>
    /// </summary>
    public class ProductFundsScanWithdrawResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Withdraw
            {
                /// <summary>
                /// 获取或设置商户提现单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
                public string OutRequestNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置提现状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置提现金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置失败原因。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string? FailReason { get; set; }

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }

                /// <summary>
                /// 获取或设置银行附言。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_memo")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_memo")]
                public string? BankMemo { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxpay_update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("wxpay_update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxpay_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("wxpay_create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置提现记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Withdraw[] WithdrawList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
