namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/intracity/getcity 接口的响应。</para>
    /// </summary>
    public class CgibinExpressIntracityGetCityResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Support
            {
                public static class Types
                {
                    public class City
                    {
                        /// <summary>
                        /// 获取或设置城市行政区域编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_code")]
                        public int CityCode { get; set; }

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                        public string? CityName { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置运力 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_trans_id")]
                [System.Text.Json.Serialization.JsonPropertyName("service_trans_id")]
                public string? ServiceTransportId { get; set; }

                /// <summary>
                /// 获取或设置城市列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("city_list")]
                [System.Text.Json.Serialization.JsonPropertyName("city_list")]
                public List<Types.City>? CityList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置运力支持列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_list")]
        [System.Text.Json.Serialization.JsonPropertyName("support_list")]
        public List<Types.Support>? SupportList { get; set; }
    }
}
