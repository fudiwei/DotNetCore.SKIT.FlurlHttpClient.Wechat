namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/security/get_server_domain_ip 接口的响应。</para>
    /// </summary>
    public class CgibinSecurityGetServerDomainIpResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ServerDomain
            {
                /// <summary>
                /// 获取或设置域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain")]
                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                public string Domain { get; set; } = default!;

                /// <summary>
                /// 获取或设置泛域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("universal_domian")]
                [System.Text.Json.Serialization.JsonPropertyName("universal_domian")]
                public string? UniversalDomain { get; set; }

                /// <summary>
                /// 获取或设置协议。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("protocol")]
                [System.Text.Json.Serialization.JsonPropertyName("protocol")]
                public string Protocol { get; set; } = default!;

                /// <summary>
                /// 获取或设置端口号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("port")]
                [System.Text.Json.Serialization.JsonPropertyName("port")]
                public int[] PortList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否必要。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_necessary")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_necessary")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanReadOnlyConverter))]
                public bool IsNecessary { get; set; }

                /// <summary>
                /// 获取或设置功能描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;
            }

            public class ServerIp
            {
                /// <summary>
                /// 获取或设置 IP 地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip")]
                [System.Text.Json.Serialization.JsonPropertyName("ip")]
                public string Ip { get; set; } = default!;

                /// <summary>
                /// 获取或设置协议。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("protocol")]
                [System.Text.Json.Serialization.JsonPropertyName("protocol")]
                public string Protocol { get; set; } = default!;

                /// <summary>
                /// 获取或设置端口号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("port")]
                [System.Text.Json.Serialization.JsonPropertyName("port")]
                public int[] PortList { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否必要。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_necessary")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanReadOnlyConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_necessary")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanReadOnlyConverter))]
                public bool IsNecessary { get; set; }

                /// <summary>
                /// 获取或设置功能描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("description")]
                [System.Text.Json.Serialization.JsonPropertyName("description")]
                public string Description { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置域名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("domain_list")]
        [System.Text.Json.Serialization.JsonPropertyName("domain_list")]
        public Types.ServerDomain[] DomainList { get; set; } = default!;

        /// <summary>
        /// 获取或设置 IP 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ip_list")]
        [System.Text.Json.Serialization.JsonPropertyName("ip_list")]
        public Types.ServerIp[] IpList { get; set; } = default!;
    }
}
