using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/callback/check 接口的响应。</para>
    /// </summary>
    public class CgibinCallbackCheckResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DNS
            {
                /// <summary>
                /// 获取或设置解析 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip")]
                [System.Text.Json.Serialization.JsonPropertyName("ip")]
                public string IP { get; set; } = default!;

                /// <summary>
                /// 获取或设置 IP 对应的运营商。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("real_operator")]
                [System.Text.Json.Serialization.JsonPropertyName("real_operator")]
                public string RealOperator { get; set; } = default!;
            }

            public class Ping
            {
                /// <summary>
                /// 获取或设置 ping IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ip")]
                [System.Text.Json.Serialization.JsonPropertyName("ip")]
                public string IP { get; set; } = default!;

                /// <summary>
                /// 获取或设置 IP 源头的运营商。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("from_operator")]
                [System.Text.Json.Serialization.JsonPropertyName("from_operator")]
                public string FromOperator { get; set; } = default!;

                /// <summary>
                /// 获取或设置丢包率字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("package_loss")]
                [System.Text.Json.Serialization.JsonPropertyName("package_loss")]
                public string PackageLossString { get; set; } = default!;

                /// <summary>
                /// 获取或设置耗时字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time")]
                [System.Text.Json.Serialization.JsonPropertyName("time")]
                public string TimeCostString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置 DNS 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dns")]
        [System.Text.Json.Serialization.JsonPropertyName("dns")]
        public Types.DNS[]? DNSList { get; set; }

        /// <summary>
        /// 获取或设置 ping 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ping")]
        [System.Text.Json.Serialization.JsonPropertyName("ping")]
        public Types.Ping[]? PingList { get; set; }
    }
}
