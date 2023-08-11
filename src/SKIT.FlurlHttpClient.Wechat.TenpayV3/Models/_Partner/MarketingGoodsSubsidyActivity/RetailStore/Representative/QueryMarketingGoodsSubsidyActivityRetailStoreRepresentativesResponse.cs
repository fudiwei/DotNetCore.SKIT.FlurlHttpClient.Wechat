namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/goods-subsidy-activity/retail-store-act/{activity_id}/representatives 接口的响应。</para>
    /// </summary>
    public class QueryMarketingGoodsSubsidyActivityRetailStoreRepresentativesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Representative
            {
                /// <summary>
                /// 获取或设置业务代理的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置业务代理列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Representative[]? RepresentativeList { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }
    }
}
