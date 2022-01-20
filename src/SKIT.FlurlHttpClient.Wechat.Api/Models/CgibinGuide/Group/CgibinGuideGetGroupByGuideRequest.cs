namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getgroupbyguide 接口的请求。</para>
    /// </summary>
    public class CgibinGuideGetGroupByGuideRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置顾问微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_account")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_account")]
        public string GuideAccount { get; set; } = string.Empty;
    }
}
