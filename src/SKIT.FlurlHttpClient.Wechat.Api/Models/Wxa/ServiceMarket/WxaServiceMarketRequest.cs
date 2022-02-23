namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/servicemarket 接口的请求。</para>
    /// </summary>
    public class WxaServiceMarketRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service")]
        [System.Text.Json.Serialization.JsonPropertyName("service")]
        public string ServiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接口名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("api")]
        [System.Text.Json.Serialization.JsonPropertyName("api")]
        public string API { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否是异步 API。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("async")]
        [System.Text.Json.Serialization.JsonPropertyName("async")]
        public bool? IsAsync { get; set; }

        /// <summary>
        /// 获取或设置服务提供方接口定义的数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.DynamicObjectConverter))]
        public dynamic? Data { get; set; }

        /// <summary>
        /// 获取或设置调用方请求的唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("client_msg_id")]
        [System.Text.Json.Serialization.JsonPropertyName("client_msg_id")]
        public string ClientMessageId { get; set; } = string.Empty;
    }
}
