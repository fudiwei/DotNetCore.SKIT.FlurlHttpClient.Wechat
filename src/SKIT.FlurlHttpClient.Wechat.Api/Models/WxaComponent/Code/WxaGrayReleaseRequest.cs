namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/grayrelease 接口的请求。</para>
    /// </summary>
    public class WxaGrayReleaseRequest : WechatApiRequest, IInferable<WxaGrayReleaseRequest, WxaGrayReleaseResponse>
    {
        /// <summary>
        /// 获取或设置灰度百分比（范围：1～100）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gray_percentage")]
        [System.Text.Json.Serialization.JsonPropertyName("gray_percentage")]
        public int GrayPercentage { get; set; }

        /// <summary>
        /// 获取或设置是否支持按项目成员灰度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_debuger_first")]
        [System.Text.Json.Serialization.JsonPropertyName("support_debuger_first")]
        public bool? IsSupportDebuggerFirst { get; set; }

        /// <summary>
        /// 获取或设置是否支持按体验成员灰度。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("support_experiencer_first")]
        [System.Text.Json.Serialization.JsonPropertyName("support_experiencer_first")]
        public bool? IsSupportExperiencerFirst { get; set; }
    }
}
