using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/submerchant/batchget 接口的请求。</para>
    /// </summary>
    public class CardSubMerchantBatchGetRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置起始的子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_id")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_id")]
        public string? NextMerchantId { get; set; } = "0";

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置指定子商户状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }
    }
}
