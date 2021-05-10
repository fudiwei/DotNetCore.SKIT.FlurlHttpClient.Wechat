using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /merchant/fund/withdraw/bill-type/{bill_type} 接口的响应。</para>
    /// </summary>
    public class GetMerchantFundWithdrawBillResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置哈希类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_type")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_type")]
        public string HashType { get; set; } = default!;

        /// <summary>
        /// 获取或设置哈希值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hash_value")]
        [System.Text.Json.Serialization.JsonPropertyName("hash_value")]
        public string HashValue { get; set; } = default!;

        /// <summary>
        /// 获取或设置账单下载地址。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("download_url")]
        [System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; } = default!;
    }
}
