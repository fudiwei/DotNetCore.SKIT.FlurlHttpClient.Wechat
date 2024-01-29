namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getshowwxaitem 接口的响应。</para>
    /// </summary>
    public class WxaGetShowWxaItemResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否可以设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("can_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("can_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool CanOpen { get; set; }

        /// <summary>
        /// 获取或设置是否已经设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool IsOpen { get; set; }

        /// <summary>
        /// 获取或设置展示的公众号 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? MediaPlatformAppId { get; set; }

        /// <summary>
        /// 获取或设置展示的公众号名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? MediaPlatformNickname { get; set; }

        /// <summary>
        /// 获取或设置展示的公众号头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("headimg")]
        [System.Text.Json.Serialization.JsonPropertyName("headimg")]
        public string? MediaPlatformHeadImageUrl { get; set; }
    }
}
