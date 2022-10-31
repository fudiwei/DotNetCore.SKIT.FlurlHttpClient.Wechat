using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/category/getsub 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantCategoryGetSubResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置分类 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置分类名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置商品分类列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cate_list")]
        [System.Text.Json.Serialization.JsonPropertyName("cate_list")]
        public Types.Category[] CategoryList { get; set; } = default!;
    }
}
