using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/qrcodejumpget 接口的响应。</para>
    /// </summary>
    public class CgibinWxopenQrcodeJumpGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Rule
            {
                /// <summary>
                /// 获取或设置匹配前缀。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("prefix")]
                [System.Text.Json.Serialization.JsonPropertyName("prefix")]
                public string Prefix { get; set; } = default!;

                /// <summary>
                /// 获取或设置符合独占规则。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("permit_sub_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("permit_sub_rule")]
                public int PermitSubRule { get; set; }

                /// <summary>
                /// 获取或设置发布状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public int State { get; set; }

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置测试范围。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_version")]
                [System.Text.Json.Serialization.JsonPropertyName("open_version")]
                public int OpenVersion { get; set; }

                /// <summary>
                /// 获取或设置测试链接列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("debug_url")]
                [System.Text.Json.Serialization.JsonPropertyName("debug_url")]
                public string[] DebugUrlList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置二维码规则总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list_size")]
        [System.Text.Json.Serialization.JsonPropertyName("list_size")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置二维码规则列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rule_list")]
        [System.Text.Json.Serialization.JsonPropertyName("rule_list")]
        public Types.Rule[] RuleList { get; set; } = default!;

        /// <summary>
        /// 获取或设置本月还可发布的次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcodejump_pub_quota")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcodejump_pub_quota")]
        public int QrcodeJumpPublishQuota { get; set; }

        /// <summary>
        /// 获取或设置是否已经打开二维码跳转链接设置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcodejump_open")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("qrcodejump_open")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
        public bool IsQrcodeJumpStore { get; set; }
    }
}
