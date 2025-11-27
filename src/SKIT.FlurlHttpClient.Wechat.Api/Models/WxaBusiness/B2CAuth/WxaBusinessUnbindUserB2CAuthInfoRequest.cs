using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/unbinduserb2cauthinfo 接口的请求。</para>
    /// </summary>
    public class WxaBusinessUnbindUserB2CAuthInfoRequest : WechatApiRequest, IInferable<WxaBusinessUnbindUserB2CAuthInfoRequest, WxaBusinessUnbindUserB2CAuthInfoResponse>
    {
        /// <summary>
        /// 获取或设置解绑用户的 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("openid_list")]
        public IList<string> OpenIdList { get; set; } = new List<string>();
}
}
