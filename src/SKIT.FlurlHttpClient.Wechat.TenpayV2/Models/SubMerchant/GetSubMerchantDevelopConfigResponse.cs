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
                public AppIdConfigItem[] Items { get; set; } = default!;
            }

            public class AppIdConfigItem
            {
                /// <summary>
                /// 获取或设置关联 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sub_appid")]
                [System.Text.Json.Serialization.JsonPropertyName("sub_appid")]
                public string SubAppId { get; set; } = default!;

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
                public string[] Items { get; set; } = default!;
            }
        }

        internal static class Converters
        {
            internal class ResponsePropertyAppIdConfigListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.AppIdConfigList>
            {
            }

            internal class ResponsePropertyAppIdConfigListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.AppIdConfigList>
            {
            }

            internal class ResponsePropertyJsapiPathListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.JsapiPathList>
            {
            }

            internal class ResponsePropertyJsapiPathListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<Types.JsapiPathList>
            {
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
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyAppIdConfigListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("appid_config_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyAppIdConfigListSystemTextJsonConverter))]
        public Types.AppIdConfigList AppIdConfigList { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权目录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jsapi_path_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.ResponsePropertyJsapiPathListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("jsapi_path_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.ResponsePropertyJsapiPathListSystemTextJsonConverter))]
        public Types.JsapiPathList JsapiPathList { get; set; } = default!;
    }
}
