using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/tags/get 接口的响应。</para>
    /// </summary>
    public class CgibinTagsGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Tag
            {
                /// <summary>
                /// 获取或设置标签 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int Id { get; set; }

                /// <summary>
                /// 获取或设置标签名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置此标签下粉丝数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("count")]
                [System.Text.Json.Serialization.JsonPropertyName("count")]
                public int Count { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置标签列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tags")]
        [System.Text.Json.Serialization.JsonPropertyName("tags")]
        public Types.Tag[] Tags { get; set; } = default!;
    }
}
