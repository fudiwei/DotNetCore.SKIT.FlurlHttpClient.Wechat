namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/vip/user/info/update 接口的请求。</para>
    /// </summary>
    public class WxaVipUserInfoUpdateRequest : WechatApiRequest, IInferable<WxaVipUserInfoUpdateRequest, WxaVipUserInfoUpdateResponse>
    {
        public static class Types
        {
            public class UserInfo : WxaVipUserInfoAddRequest.Types.UserInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置小程序用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小程序用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.UserInfo UserInfo { get; set; } = new Types.UserInfo();
    }
}
