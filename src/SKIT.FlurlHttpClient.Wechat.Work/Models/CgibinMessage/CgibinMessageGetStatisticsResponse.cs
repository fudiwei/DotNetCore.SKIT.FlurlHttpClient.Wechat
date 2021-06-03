using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/get_statistics 接口的响应。</para>
    /// </summary>
    public class CgibinMessageGetStatisticsResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置应用 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agentid")]
                [System.Text.Json.Serialization.JsonPropertyName("agentid")]
                public int AgentId { get; set; }

                /// <summary>
                /// 获取或设置应用名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_name")]
                [System.Text.Json.Serialization.JsonPropertyName("app_name")]
                public string AppName { get; set; } = default!;

                /// <summary>
                /// 获取或设置发消息成功人次。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int MessageCount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置统计数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("statistics")]
        [System.Text.Json.Serialization.JsonPropertyName("statistics")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
