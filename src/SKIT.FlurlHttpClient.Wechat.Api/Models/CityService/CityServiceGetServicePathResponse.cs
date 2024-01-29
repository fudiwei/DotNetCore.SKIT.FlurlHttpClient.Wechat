namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/getservicepath 接口的响应。</para>
    /// </summary>
    public class CityServiceGetServicePathResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string PagePath { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序页面参数字符串。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_string")]
        [System.Text.Json.Serialization.JsonPropertyName("query_string")]
        public string PageQueryString { get; set; } = default!;

        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
        public string? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置小程序原始 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("username")]
        [System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }
    }
}
