namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/info/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECVipUserInfoGetRequest : WechatApiRequest, IInferable<ChannelsECVipUserInfoGetRequest, ChannelsECVipUserInfoGetResponse>
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否需要获取手机号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("need_phone_number")]
        public bool? RequirePhoneNumber { get; set; }
    }
}
