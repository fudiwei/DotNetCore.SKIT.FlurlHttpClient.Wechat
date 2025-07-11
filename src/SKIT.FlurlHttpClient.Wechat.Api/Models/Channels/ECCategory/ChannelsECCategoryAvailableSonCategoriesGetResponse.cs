using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/availablesoncategories/get 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-07-01 下线。")]
    public class ChannelsECCategoryAvailableSonCategoriesGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Category
            {
                /// <summary>
                /// 获取或设置类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long longCategoryId { get; set; }

                /// <summary>
                /// 获取或设置类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置上级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("f_cat_id")]
                [System.Text.Json.Serialization.JsonPropertyName("f_cat_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long ParentCategoryId { get; set; }

                /// <summary>
                /// 获取或设置是否是叶子节点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("leaf")]
                [System.Text.Json.Serialization.JsonPropertyName("leaf")]
                public bool? IsLeaf { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置类目列表。
        /// </summary>
        [Obsolete("相关接口或字段于 2024-10-28 下线。")]
        [Newtonsoft.Json.JsonProperty("cat_list")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_list")]
        public Types.Category[] CategoryList { get; set; } = default!;

        /// <summary>
        /// 获取或设置新版类目列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_list_v2")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_list_v2")]
        public Types.Category[] CategoryV2List { get; set; } = default!;
    }
}
