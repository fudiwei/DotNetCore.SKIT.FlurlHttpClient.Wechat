namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/get_effective_domain 接口的响应。</para>
    /// </summary>
    public class WxaGetEffectiveDomainResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Domain
            {
                /// <summary>
                /// 获取或设置 Request 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("requestdomain")]
                [System.Text.Json.Serialization.JsonPropertyName("requestdomain")]
                public string[] RequestDomainList { get; set; } = default!;

                /// <summary>
                /// 获取或设置 Socket 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wsrequestdomain")]
                [System.Text.Json.Serialization.JsonPropertyName("wsrequestdomain")]
                public string[] WebSocketDomainList { get; set; } = default!;

                /// <summary>
                /// 获取或设置 UploadFile 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("uploaddomain")]
                [System.Text.Json.Serialization.JsonPropertyName("uploaddomain")]
                public string[] UploadDomainList { get; set; } = default!;

                /// <summary>
                /// 获取或设置 DownloadFile 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("downloaddomain")]
                [System.Text.Json.Serialization.JsonPropertyName("downloaddomain")]
                public string[] DownloadDomainList { get; set; } = default!;

                /// <summary>
                /// 获取或设置 UDP 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("udpdomain")]
                [System.Text.Json.Serialization.JsonPropertyName("udpdomain")]
                public string[] UdpDomainList { get; set; } = default!;

                /// <summary>
                /// 获取或设置 TCP 合法域名列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tcpdomain")]
                [System.Text.Json.Serialization.JsonPropertyName("tcpdomain")]
                public string[] TcpDomainList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置通过公众平台配置的服务器域名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mp_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("mp_domain")]
        public Types.Domain? MpDomain { get; set; }

        /// <summary>
        /// 获取或设置通过第三方平台接口配置的服务器域名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("third_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("third_domain")]
        public Types.Domain? ThirdDomain { get; set; }

        /// <summary>
        /// 获取或设置通过 ModifyServerDomainDirectly 接口配置的服务器域名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direct_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("direct_domain")]
        public Types.Domain? DirectlyDomain { get; set; }

        /// <summary>
        /// 获取或设置最后提交代码或者发布上线后生效的域名信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effective_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("effective_domain")]
        public Types.Domain? EffectiveDomain { get; set; }
    }
}
