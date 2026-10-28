namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/wxamplinkget 接口的响应。</para>
    /// </summary>
    public class CgibinWxopenWxaMpLinkGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MiniProgramList
            {
                /// <summary>
                /// 获取或设置关联的小程序列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public List<MiniProgramItem>? Items { get; set; }
            }

            public class MiniProgramItem
            {
                public static class Types
                {
                    public class Function
                    {
                        /// <summary>
                        /// 获取或设置功能 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        public int Id { get; set; }

                        /// <summary>
                        /// 获取或设置功能名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string? Name { get; set; }

                        /// <summary>
                        /// 获取或设置开通状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置小程序原始账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("username")]
                [System.Text.Json.Serialization.JsonPropertyName("username")]
                public string? UserName { get; set; }

                /// <summary>
                /// 获取或设置小程序昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string? Nickname { get; set; }

                /// <summary>
                /// 获取或设置小程序头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimg_url")]
                [System.Text.Json.Serialization.JsonPropertyName("headimg_url")]
                public string? HeadImageUrl { get; set; }

                /// <summary>
                /// 获取或设置小程序邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }

                /// <summary>
                /// 获取或设置关联来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("source")]
                [System.Text.Json.Serialization.JsonPropertyName("source")]
                public string? Source { get; set; }

                /// <summary>
                /// 获取或设置关联状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置是否在公众号管理页展示中。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("selected")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("selected")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                public bool? IsSelected { get; set; }

                /// <summary>
                /// 获取或设置是否展示在附近的小程序中。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nearby_display_status")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("nearby_display_status")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                public bool? IsNearby { get; set; }

                /// <summary>
                /// 获取或设置是否已经发布。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("released")]
                [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("released")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanConverter))]
                public bool? IsReleased { get; set; }

                /// <summary>
                /// 获取或设置功能列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("func_infos")]
                [System.Text.Json.Serialization.JsonPropertyName("func_infos")]
                public List<Types.Function>? FunctionList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置关联的小程序列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxopens")]
        [System.Text.Json.Serialization.JsonPropertyName("wxopens")]
        public Types.MiniProgramList? MiniProgramList { get; set; }
    }
}
