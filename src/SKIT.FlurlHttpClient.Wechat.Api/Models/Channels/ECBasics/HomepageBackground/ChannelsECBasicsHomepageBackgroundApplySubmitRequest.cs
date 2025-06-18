namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/homepage/background/apply/submit 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsHomepageBackgroundApplySubmitRequest : WechatApiRequest, IInferable<ChannelsECBasicsHomepageBackgroundApplySubmitRequest, ChannelsECBasicsHomepageBackgroundApplySubmitResponse>
    {
        /// <summary>
        /// 获取或设置图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_url")]
        [System.Text.Json.Serialization.JsonPropertyName("img_url")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
