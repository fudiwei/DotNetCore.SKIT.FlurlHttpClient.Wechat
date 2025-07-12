namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/info/delete 接口的请求。</para>
    /// </summary>
    public class ChannelsECVipUserInfoDeleteRequest : WechatApiRequest, IInferable<ChannelsECVipUserInfoDeleteRequest, ChannelsECVipUserInfoDeleteResponse>
    {
        /// <summary>
        /// 获取或设置小程序用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
