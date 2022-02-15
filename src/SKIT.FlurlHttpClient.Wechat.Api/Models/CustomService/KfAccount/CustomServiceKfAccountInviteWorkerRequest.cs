using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /customservice/kfaccount/inviteworker 接口的请求。</para>
    /// </summary>
    public class CustomServiceKfAccountInviteWorkerRequest : WechatApiRequest, IMapResponse<CustomServiceKfAccountInviteWorkerRequest, CustomServiceKfAccountInviteWorkerResponse>
    {
        /// <summary>
        /// 获取或设置客服账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kf_account")]
        [System.Text.Json.Serialization.JsonPropertyName("kf_account")]
        public string KfAccount { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收绑定邀请的客服微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invite_wx")]
        [System.Text.Json.Serialization.JsonPropertyName("invite_wx")]
        public string InviteWxname { get; set; } = string.Empty;
    }
}
