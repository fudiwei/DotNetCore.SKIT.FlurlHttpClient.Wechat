namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/scene/check 接口的响应。</para>
    /// </summary>
    public class ShopSceneCheckResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否在支付校验范围内。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_matched")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_matched")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsMatched { get; set; }
    }
}
