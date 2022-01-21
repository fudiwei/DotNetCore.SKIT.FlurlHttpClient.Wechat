using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchantfund/partner/income-records 接口的响应。</para>
    /// </summary>
    public class QueryMerchantFundPartnerIncomeRecordsResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class IncomeRecord
            {
                /// <summary>
                /// 获取或设置特约商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
                public string SubMerchantId { get; set; } = default!;

                /// <summary>
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public string AccountType { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行来账类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("income_record_type")]
                [System.Text.Json.Serialization.JsonPropertyName("income_record_type")]
                public string IncomeRecordType { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行来账微信单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("income_record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("income_record_id")]
                public string IncomeRecordId { get; set; } = default!;

                /// <summary>
                /// 获取或设置银行来账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置企业微信的员工工号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("success_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset SuccessTime { get; set; }

                /// <summary>
                /// 获取或设置付款方银行名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string BankName { get; set; } = default!;

                /// <summary>
                /// 获取或设置付款方银行户名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_name")]
                public string BankAccountName { get; set; } = default!;

                /// <summary>
                /// 获取或设置付款方银行卡号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_number")]
                public string BankAccountNumber { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置银行来账记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.IncomeRecord[]? IncomeRecordList { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置分页开始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置银行来账记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

    }
}
