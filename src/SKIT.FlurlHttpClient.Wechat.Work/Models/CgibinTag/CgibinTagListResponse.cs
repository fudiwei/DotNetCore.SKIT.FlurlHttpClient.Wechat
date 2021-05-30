using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/tag/list 接口的响应。</para>
    /// </summary>
    public class CgibinTagListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Tag
            {
                /// <summary>
                /// 获取或设置标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagid")]
                [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                public int TagId { get; set; }

                /// <summary>
                /// 获取或设置标签名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagname")]
                [System.Text.Json.Serialization.JsonPropertyName("tagname")]
                public string Name { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("taglist")]
        [System.Text.Json.Serialization.JsonPropertyName("taglist")]
        public Types.Tag[] TagList { get; set; } = default!;
    }
}
