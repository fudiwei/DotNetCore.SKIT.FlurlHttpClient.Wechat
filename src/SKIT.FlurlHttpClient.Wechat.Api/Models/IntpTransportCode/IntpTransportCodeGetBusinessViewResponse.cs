namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/transportcode/getbusinessview 接口的响应。</para>
    /// </summary>
    public class IntpTransportCodeGetBusinessViewResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置业务类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_type")]
        [System.Text.Json.Serialization.JsonPropertyName("business_type")]
        public string? BusinessType { get; set; }

        /// <summary>
        /// 获取或设置调用仿原生小程序时使用的参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("query_string")]
        [System.Text.Json.Serialization.JsonPropertyName("query_string")]
        public string? QueryString { get; set; }

        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        public long ExpireTimestamp { get; set; }
    }
}
