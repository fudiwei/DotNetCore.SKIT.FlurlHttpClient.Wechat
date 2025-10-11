namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /webizpay/stores/entity-matches/{batch_id} 接口的响应。</para>
    /// </summary>
    public class GetWeBusinessPayStoreEntityMatchByBatchIdResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class MatchResult
            {
                /// <summary>
                /// 获取或设置门店统一社会信用代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization_code")]
                [System.Text.Json.Serialization.JsonPropertyName("organization_code")]
                public string OrganizationCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否存在满足条件微信支付商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("has_valid_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("has_valid_mchid")]
                public bool HasValidMerchantId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户主体匹配批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_batch_id")]
        public string OutBatchId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付主体匹配批次单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("batch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("batch_id")]
        public string BatchId { get; set; } = default!;

        /// <summary>
        /// 获取或设置批次状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string State { get; set; } = default!;

        /// <summary>
        /// 获取或设置主体匹配明细列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("match_results")]
        [System.Text.Json.Serialization.JsonPropertyName("match_results")]
        public Types.MatchResult[] MatchResultList { get; set; } = default!;
    }
}
