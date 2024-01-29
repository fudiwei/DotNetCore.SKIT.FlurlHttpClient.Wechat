namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/wxamplink 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenWxaMpLinkRequest : WechatApiRequest, IInferable<CgibinWxopenWxaMpLinkRequest, CgibinWxopenWxaMpLinkResponse>
    {
        /// <summary>
        /// 获取或设置小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string MiniProgramAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否发送模板消息通知公众号粉丝。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_users")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("notify_users")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool RequireNotifyUsers { get; set; }

        /// <summary>
        /// 获取或设置是否展示公众号主页中。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("show_profile")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("show_profile")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool RequireShowInProfile { get; set; }
    }
}
