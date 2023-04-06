namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/merchant/tax-codes 接口的响应。</para>
    /// </summary>
    public class QueryNewTaxControlFapiaoMerchantTaxCodesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Tax
            {
                /// <summary>
                /// 获取或设置货物或应税劳务或服务编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_code")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_code")]
                public string TaxCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置货物或应税劳务或服务名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("goods_name")]
                [System.Text.Json.Serialization.JsonPropertyName("goods_name")]
                public string GoodsName { get; set; } = default!;

                /// <summary>
                /// 获取或设置税率（单位：万分数）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_rate")]
                public int TaxRate { get; set; }

                /// <summary>
                /// 获取或设置税收优惠政策标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tax_prefer_mark")]
                [System.Text.Json.Serialization.JsonPropertyName("tax_prefer_mark")]
                public string TaxPreferMark { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品和服务税收分类对照信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Tax[] TaxList { get; set; } = default!;

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset")]
        [System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
