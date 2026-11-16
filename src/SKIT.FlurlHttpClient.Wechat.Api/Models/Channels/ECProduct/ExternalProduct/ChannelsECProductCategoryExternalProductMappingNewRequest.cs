namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/externalproductmappingnew 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductCategoryExternalProductMappingNewRequest : WechatApiRequest, IInferable<ChannelsECProductCategoryExternalProductMappingNewRequest, ChannelsECProductCategoryExternalProductMappingNewResponse>
    {
        public static class Types
        {
            public class ExternalAttribute
            {
                /// <summary>
                /// 获取或设置外部商品属性键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string? Key { get; set; }

                /// <summary>
                /// 获取或设置外部商品属性值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? Title { get; set; }

        /// <summary>
        /// 获取或设置商品头图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_imgs")]
        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
        public List<string>? HeadImageUrlList { get; set; }

        /// <summary>
        /// 获取或设置商品详情图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_imgs")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_imgs")]
        public List<string>? DetailImageUrlList { get; set; }

        /// <summary>
        /// 获取或设置外部商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_attributes")]
        [System.Text.Json.Serialization.JsonPropertyName("external_attributes")]
        public List<Types.ExternalAttribute>? ExternalAttributeList { get; set; }

        /// <summary>
        /// 获取或设置外部商品类目名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_category_name")]
        [System.Text.Json.Serialization.JsonPropertyName("external_category_name")]
        public string? ExternalCategoryName { get; set; }
    }
}
