using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/fund/withdraw 接口的请求。</para>
    /// </summary>
    public class CreateMerchantFundWithdrawRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商户提现单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置提现金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置提现备注。
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
        /// 获取或设置出款账户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_type")]
        [System.Text.Json.Serialization.JsonPropertyName("account_type")]
        public string AccountType { get; set; } = string.Empty;
    }
}
