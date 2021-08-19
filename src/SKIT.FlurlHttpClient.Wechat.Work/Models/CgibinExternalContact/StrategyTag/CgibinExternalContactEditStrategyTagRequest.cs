using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/edit_strategy_tag 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactEditStrategyTagRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置企业标签或标签分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id")]
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string TagOrGroupId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置企业标签或标签分组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? TagOrGroupName { get; set; }

        /// <summary>
        /// 获取或设置企业标签或标签分组次序值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? TagOrGroupOrder { get; set; }
    }
}
