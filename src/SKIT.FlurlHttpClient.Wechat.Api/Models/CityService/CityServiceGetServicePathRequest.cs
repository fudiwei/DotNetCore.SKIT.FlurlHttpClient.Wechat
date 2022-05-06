using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/getservicepath 接口的请求。</para>
    /// </summary>
    public class CityServiceGetServicePathRequest : WechatApiRequest, IInferable<CityServiceGetServicePathRequest, CityServiceGetServicePathResponse>
    {
        public static class Types
        {
            public class Parameter
            {
                /// <summary>
                /// 获取或设置键。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("key")]
                [System.Text.Json.Serialization.JsonPropertyName("key")]
                public string Key { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("value")]
                [System.Text.Json.Serialization.JsonPropertyName("value")]
                public string Value { get; set; } = string.Empty;
            }
        }

        internal static class Converters
        {
            internal class RequestPropertyParameterListNewtonsoftJsonConverter : Newtonsoft.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Parameter>>
            {
            }

            internal class RequestPropertyParameterListSystemTextJsonConverter : System.Text.Json.Converters.TextualObjectInJsonFormatConverterBase<IList<Types.Parameter>>
            {
            }
        }

        /// <summary>
        /// 获取或设置城市服务路径类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_type")]
        [System.Text.Json.Serialization.JsonPropertyName("page_type")]
        public int PageType { get; set; }

        /// <summary>
        /// 获取或设置跳转来源渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("src_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("src_channel")]
        public int SourceChannel { get; set; }

        /// <summary>
        /// 获取或设置城市名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("city_name")]
        [System.Text.Json.Serialization.JsonPropertyName("city_name")]
        public string? CityName { get; set; }

        /// <summary>
        /// 获取或设置卡片类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_type")]
        [System.Text.Json.Serialization.JsonPropertyName("card_type")]
        public int? CardType { get; set; }

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public int? ServiceId { get; set; }

        /// <summary>
        /// 获取或设置专题页名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content_name")]
        [System.Text.Json.Serialization.JsonPropertyName("content_name")]
        public string? ContentName { get; set; }

        /// <summary>
        /// 获取或设置参数列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("params")]
        [Newtonsoft.Json.JsonConverter(typeof(Converters.RequestPropertyParameterListNewtonsoftJsonConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("params")]
        [System.Text.Json.Serialization.JsonConverter(typeof(Converters.RequestPropertyParameterListSystemTextJsonConverter))]
        public IList<Types.Parameter>? ParameterList { get; set; }

        /// <summary>
        /// 获取或设置额外参数列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ext_params")]
        [System.Text.Json.Serialization.JsonPropertyName("ext_params")]
        public IList<Types.Parameter>? ExtraParameterList { get; set; }
    }
}
