namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/icp/query_icp_service_content_types 接口的响应。</para>
    /// </summary>
    public class WxaICPQueryICPServiceContentTypesResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Item
            {
                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置父类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_type")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_type")]
                public int? ParentType { get; set; }

                /// <summary>
                /// 获取或设置名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string? Remark { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务内容类型列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Item[] ItemList { get; set; } = default!;
    }
}
