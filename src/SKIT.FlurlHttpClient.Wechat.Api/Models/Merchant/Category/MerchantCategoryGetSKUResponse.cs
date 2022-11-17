using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/category/getsku 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantCategoryGetSKUResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SKU
            {
                public static class Types
                {
                    public class Value
                    {
                        /// <summary>
                        /// 获取或设置 VID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public string Id { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 VID 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string Id { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU 名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置 SKU VID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value_list")]
                [System.Text.Json.Serialization.JsonPropertyName("value_list")]
                public Types.Value[] ValueList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_table")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_table")]
        public Types.SKU[] SKUList { get; set; } = default!;
    }
}
