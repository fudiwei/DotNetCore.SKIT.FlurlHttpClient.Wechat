using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wxopen/qrcodejumpadd 接口的请求。</para>
    /// </summary>
    public class CgibinWxopenQrcodeJumpAddRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置匹配前缀。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("prefix")]
        [System.Text.Json.Serialization.JsonPropertyName("prefix")]
        public string Prefix { get; set; } = string.Empty;

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
        public string PagePath { get; set; } = string.Empty;

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
        public IList<string>? DebugUrlList { get; set; }

        /// <summary>
        /// 获取或设置是否是编辑已有二维码规则。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_edit")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumberTypedBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_edit")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumberTypedBooleanConverter))]
        public bool IsEdit { get; set; }
    }
}
