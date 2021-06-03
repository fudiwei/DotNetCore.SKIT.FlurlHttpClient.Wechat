using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/get_admin_list 接口的请求。</para>
    /// </summary>
    public class CgibinServiceGetAdminListRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置授权方 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_corpid")]
        public string AuthorizerCorpId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置授权方安装的应用 AgentId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int AgentId { get; set; }
    }
}
