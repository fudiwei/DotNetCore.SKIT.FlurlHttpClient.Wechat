namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/icp/query_icp_district_code 接口的响应。</para>
    /// </summary>
    public class WxaICPQueryICPDistrictCodeResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Item
            {
                /// <summary>
                /// 获取或设置区域类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置区域代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string Code { get; set; } = default!;

                /// <summary>
                /// 获取或设置区域名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置下级区域信息列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_list")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_list")]
                public Item[]? SubItemlist { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置区域信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("items")]
        [System.Text.Json.Serialization.JsonPropertyName("items")]
        public Types.Item[] ItemList { get; set; } = default!;
    }
}
