using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/get_api_domain_ip 接口的响应。</para>
    /// </summary>
    public class CgibinGetApiDomainIpResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置企业微信服务器 IP 段列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ip_list")]
        public string[] IPList { get; set; } = default!;
    }
}
