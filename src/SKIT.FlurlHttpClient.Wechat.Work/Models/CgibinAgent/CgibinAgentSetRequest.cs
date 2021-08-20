using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/agent/set 接口的请求。</para>
    /// </summary>
    public class CgibinAgentSetRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置应用 ID。如果不指定将使用构造 <see cref="WechatWorkClient"/> 时的 <see cref="WechatWorkClientOptions.AgentId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int? AgentId { get; set; }

        /// <summary>
        /// 获取或设置应用名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置头像 LogoMediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("logo_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("logo_mediaid")]
        public string? LogoMediaId { get; set; }

        /// <summary>
        /// 获取或设置应用详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置是否上报用户地理位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_location_flag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("report_location_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsReportLocation { get; set; }

        /// <summary>
        /// 获取或设置是否上报用户进入事件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isreportenter")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("isreportenter")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsReportEnter { get; set; }

        /// <summary>
        /// 获取或设置可信域名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_domain")]
        public string? RedirectDomain { get; set; }

        /// <summary>
        /// 获取或设置应用主页。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("home_url")]
        [System.Text.Json.Serialization.JsonPropertyName("home_url")]
        public string? HomeUrl { get; set; }
    }
}
