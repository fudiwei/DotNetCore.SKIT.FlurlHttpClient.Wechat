using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/fund/dayendbalance/{account_type} 接口的响应。</para>
    /// </summary>
    public class GetMerchantFundDayendBalanceResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置可用余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("available_amount")]
        public long AvailableAmount { get; set; }

        /// <summary>
        /// 获取或设置不可用余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pending_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("pending_amount")]
        public long PendingAmount { get; set; }
    }
}
