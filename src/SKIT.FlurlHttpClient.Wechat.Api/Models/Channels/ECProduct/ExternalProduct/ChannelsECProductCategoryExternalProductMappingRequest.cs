namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/externalproductmapping 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductCategoryExternalProductMappingRequest : WechatApiRequest, IInferable<ChannelsECProductCategoryExternalProductMappingRequest, ChannelsECProductCategoryExternalProductMappingResponse>
    {
        /// <summary>
        /// 获取或设置商品类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 获取或设置外部商品属性键。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_attribute_name")]
        [System.Text.Json.Serialization.JsonPropertyName("external_attribute_name")]
        public string? ExternalAttributeName { get; set; }

        /// <summary>
        /// 获取或设置外部商品属性值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_attribute_value")]
        [System.Text.Json.Serialization.JsonPropertyName("external_attribute_value")]
        public string? ExternalAttributeValue { get; set; }

        /// <summary>
        /// 获取或设置外部商品类目名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_category_name")]
        [System.Text.Json.Serialization.JsonPropertyName("external_category_name")]
        public string? ExternalCategoryName { get; set; }
    }
}
