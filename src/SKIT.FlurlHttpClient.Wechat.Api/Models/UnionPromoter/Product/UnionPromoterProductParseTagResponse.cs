namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/product/parse_tag 接口的响应。</para>
    /// </summary>
    public class UnionPromoterProductParseTagResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Tag
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productId")]
                [System.Text.Json.Serialization.JsonPropertyName("productId")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ProductId { get; set; }

                /// <summary>
                /// 获取或设置商品来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public int Source { get; set; }

                /// <summary>
                /// 获取或设置小商店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("productAppid")]
                [System.Text.Json.Serialization.JsonPropertyName("productAppid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int? ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品推广 Tag 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagList")]
        [System.Text.Json.Serialization.JsonPropertyName("tagList")]

        public Types.Tag[] TagList { get; set; } = default!;
    }
}
