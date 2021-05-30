using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguideacctconfig 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideAccountConfigResponse : WechatApiResponse
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
                public string[] Values { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updatetime")]
                [System.Text.Json.Serialization.JsonPropertyName("updatetime")]
                public long UpdateTimestamp { get; set; }
            }

            public class AutoReply
            {
                /// <summary>
                /// 获取或设置自动回复内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("updatetime")]
                [System.Text.Json.Serialization.JsonPropertyName("updatetime")]
                public long UpdateTimestamp { get; set; }
            }
        }

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
