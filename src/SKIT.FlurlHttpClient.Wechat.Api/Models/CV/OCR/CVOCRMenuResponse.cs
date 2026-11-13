namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/menu 接口的响应。</para>
    /// </summary>
    public class CVOCRMenuResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Content
            {
                public static class Types
                {
                    public class MenuItem
                    {
                        /// <summary>
                        /// 获取或设置名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置价格（单位：元）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("price")]
                        [System.Text.Json.Serialization.JsonPropertyName("price")]
                        public decimal Price { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置菜单项列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("menu_items")]
                [System.Text.Json.Serialization.JsonPropertyName("menu_items")]
                public List<Types.MenuItem>? MenuItemList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置菜单内容信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
        public Types.Content? Content { get; set; }
    }
}
