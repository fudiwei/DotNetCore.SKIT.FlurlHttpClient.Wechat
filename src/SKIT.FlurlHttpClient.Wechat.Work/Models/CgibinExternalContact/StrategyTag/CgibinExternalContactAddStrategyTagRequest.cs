using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/add_strategy_tag 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactAddStrategyTagRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Tag
            {
                /// <summary>
                /// 获取或设置企业标签名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置次序值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public int? Order { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy_id")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
        public int StrategyId { get; set; }

        /// <summary>
        /// 获取或设置企业标签分组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("group_id")]
        public string? TagGroupId { get; set; }

        /// <summary>
        /// 获取或设置企业标签分组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("group_name")]
        [System.Text.Json.Serialization.JsonPropertyName("group_name")]
        public string? TagGroupName { get; set; }

        /// <summary>
        /// 获取或设置企业标签分组次序值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public int? TagGroupOrder { get; set; }

        /// <summary>
        /// 获取或设置企业标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public IList<Types.Tag> TagList { get; set; } = new List<Types.Tag>();
    }
}
