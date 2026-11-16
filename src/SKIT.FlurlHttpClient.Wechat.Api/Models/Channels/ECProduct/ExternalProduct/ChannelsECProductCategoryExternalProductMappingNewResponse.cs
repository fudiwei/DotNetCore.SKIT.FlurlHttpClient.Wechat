namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/externalproductmappingnew 接口的响应。</para>
    /// </summary>
    public class ChannelsECProductCategoryExternalProductMappingNewResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Attribute
            {
                /// <summary>
                /// 获取或设置商品属性键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string? Key { get; set; }

                /// <summary>
                /// 获取或设置商品属性值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string? Value { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置商品属性列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attributes")]
        [System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public List<Types.Attribute>? AttributeList { get; set; }
    }
}
