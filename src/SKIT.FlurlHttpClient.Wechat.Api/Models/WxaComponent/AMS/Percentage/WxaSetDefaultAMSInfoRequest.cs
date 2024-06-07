namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setdefaultamsinfo 接口的请求。</para>
    /// </summary>
    public class WxaSetDefaultAMSInfoRequest : WechatApiRequest, IInferable<WxaSetDefaultAMSInfoRequest, WxaSetDefaultAMSInfoResponse>
    {
        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Action { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置分账比例（单位：百分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("share_ratio")]
        public int ShareRatio { get; set; }
    }
}
