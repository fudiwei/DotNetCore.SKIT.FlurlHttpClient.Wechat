using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/setguideacctconfig 接口的请求。</para>
    /// </summary>
    public class CgibinGuideSetGuideAccountConfigRequest : WechatApiRequest
    {
        public static class Types
        {
            public class BlackKeyword
            {
                /// <summary>
                /// 获取或设置敏感词列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("values")]
                [System.Text.Json.Serialization.JsonPropertyName("values")]
                public IList<string> Values { get; set; } = new List<string>();
            }

            public class AutoReply
            {
                /// <summary>
                /// 获取或设置自动回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_delete")]
        [System.Text.Json.Serialization.JsonPropertyName("is_delete")]
        public bool IsDelete { get; set; }

        /// <summary>
        /// 获取或设置敏感词信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("black_keyword")]
        [System.Text.Json.Serialization.JsonPropertyName("black_keyword")]
        public Types.BlackKeyword? BlackKeyword { get; set; }

        /// <summary>
        /// 获取或设置离线自动回复信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guide_auto_reply")]
        [System.Text.Json.Serialization.JsonPropertyName("guide_auto_reply")]
        public Types.AutoReply? GuideAutoReply { get; set; }
    }
}
