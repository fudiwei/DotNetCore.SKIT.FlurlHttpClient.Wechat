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
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanReadOnlyConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_subscribed")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanReadOnlyConverter))]
        public bool IsSubscribed { get; set; }
    }
}
