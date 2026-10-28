namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/mch/querysubdevconfig 接口的响应。</para>
    /// </summary>
    public class GetSubMerchantDevelopConfigResponse : WechatTenpaySignableResponse
    {
        public static class Types
        {
            public class AppIdConfigList
            {
                /// <summary>
                /// 获取或设置 AppId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid_config_list")]
                [System.Text.Json.Serialization.JsonPropertyName("appid_config_list")]
                public List<AppIdConfigItem>? Items { get; set; }
            }

            public class AppIdConfigItem
            {
                /// <summary>
                /// 获取或设置关联 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
                public string? SubAppId { get; set; }

                /// <summary>
                /// 获取或设置关注特约商户公众号的 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("subscribe_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("subscribe_appid")]
                public string? SubscribeAppId { get; set; }
            }

            public class JsapiPathList
            {
                /// <summary>
                /// 获取或设置授权目录列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("jsapi_path_list")]
                [System.Text.Json.Serialization.JsonPropertyName("jsapi_path_list")]
                public List<string>? Items { get; set; }
            }
        }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（冗余字段，请忽略）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置关联 AppId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid_config_list")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("appid_config_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
        public Types.AppIdConfigList? AppIdConfigList { get; set; }

        /// <summary>
        /// 获取或设置授权目录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jsapi_path_list")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedObjectInJsonFormatConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("jsapi_path_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedObjectInJsonFormatConverter))]
        public Types.JsapiPathList? JsapiPathList { get; set; }
    }
}
