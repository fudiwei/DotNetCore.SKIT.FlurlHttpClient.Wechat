using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /redpacketcover/wxapp/cover_url/get_by_token 接口的请求。</para>
    /// </summary>
    public class RedPacketCoverWxAppCoverUrlGetByTokenRequest : WechatApiRequest, IMapResponse<RedPacketCoverWxAppCoverUrlGetByTokenRequest, RedPacketCoverWxAppCoverUrlGetByTokenResponse>
    {
        /// <summary>
        /// 获取或设置可领取用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置红包封面平台的发放 CToken。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ctoken")]
        [System.Text.Json.Serialization.JsonPropertyName("ctoken")]
        public string CToken { get; set; } = string.Empty;
    }
}
