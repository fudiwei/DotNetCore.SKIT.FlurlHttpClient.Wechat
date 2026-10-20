namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cityservice/getmsgrelation 接口的响应。</para>
    /// </summary>
    public class CityServiceGetMessageRelationResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否已订阅。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_subscribed")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.NumericBooleanReadOnlyConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_subscribed")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.NumericBooleanReadOnlyConverter))]
        public bool IsSubscribed { get; set; }
    }
}
