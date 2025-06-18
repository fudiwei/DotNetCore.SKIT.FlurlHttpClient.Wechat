using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/sharer/unbind 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-03-07 下线。")]
    public class ChannelsECSharerUnbindRequest : WechatApiRequest, IInferable<ChannelsECSharerUnbindRequest, ChannelsECSharerUnbindResponse>
    {
        /// <summary>
        /// 获取或设置分享员 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("openid_list")]
        public IList<string> OpenIdList { get; set; } = new List<string>();
    }
}
