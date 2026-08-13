namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/card/card-links 接口的响应。</para>
    /// </summary>
    public class QueryBrandCardLinksResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Link
            {
                /// <summary>
                /// 获取或设置交易场景类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payment_scene")]
                [System.Text.Json.Serialization.JsonPropertyName("payment_scene")]
                public string PaymentScene { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_link_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("card_link_mchid")]
                public string? CardLinkMerchantId { get; set; }

                /// <summary>
                /// 获取或设置微信 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid_list")]
                [System.Text.Json.Serialization.JsonPropertyName("appid_list")]
                public string[]? AppIdList { get; set; }

                /// <summary>
                /// 获取或设置服务 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_id")]
                public string? ServiceId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置已生效连接列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("active_link_list")]
        [System.Text.Json.Serialization.JsonPropertyName("active_link_list")]
        public Types.Link[] ActiveLinkList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置分页页数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_index")]
        [System.Text.Json.Serialization.JsonPropertyName("page_index")]
        public int Page { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; }
    }
}
