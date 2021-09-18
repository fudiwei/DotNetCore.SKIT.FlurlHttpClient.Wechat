using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/funds/getbalance 接口的响应。</para>
    /// </summary>
    public class ProductFundsGetBalanceResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置可提现余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("available_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("available_amount")]
        public int AvailableAmount { get; set; }

        /// <summary>
        /// 获取或设置待结算余额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pending_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("pending_amount")]
        public int PendingAmount { get; set; }

        /// <summary>
        /// 获取或设置二级商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = default!;
    }
}
