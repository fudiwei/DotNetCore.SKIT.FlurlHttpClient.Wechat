using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /fund_transfer/add 接口的响应。</para>
    /// </summary>
    public class FundTransferAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置资金账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("fund_type")]
                [System.Text.Json.Serialization.JsonPropertyName("fund_type")]
                public string FundType { get; set; } = default!;

                /// <summary>
                /// 获取或设置金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置调用方订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_bill_no")]
                [System.Text.Json.Serialization.JsonPropertyName("external_bill_no")]
                public string? ExternalBillNumber { get; set; }

                /// <summary>
                /// 获取或设置是否重复转账。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_repeated")]
                [System.Text.Json.Serialization.JsonPropertyName("is_repeated")]
                public bool IsRepeated { get; set; }

                /// <summary>
                /// 获取或设置交易时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
