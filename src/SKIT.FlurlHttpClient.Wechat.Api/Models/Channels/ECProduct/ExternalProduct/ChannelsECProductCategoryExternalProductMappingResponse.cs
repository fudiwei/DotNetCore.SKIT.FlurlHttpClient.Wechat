namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/externalproductmapping 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductCategoryExternalProductMappingResponse : WechatApiResponse
    {
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
        /// 获取或设置内部商品属性键。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internal_attribute_name")]
        [System.Text.Json.Serialization.JsonPropertyName("internal_attribute_name")]
        public string? InternalAttributeName { get; set; }

        /// <summary>
        /// 获取或设置内部商品属性值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internal_attribute_value")]
        [System.Text.Json.Serialization.JsonPropertyName("internal_attribute_value")]
        public string[]? InternalAttributeValueList { get; set; }
    }
}
