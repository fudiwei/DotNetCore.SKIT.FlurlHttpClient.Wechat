using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/guide/getguidewordmaterial 接口的响应。</para>
    /// </summary>
    public class CgibinGuideGetGuideWordMaterialResponse : WechatApiResponse
    {
        public static class Types
        {
            public class WordMaterial
            {
                /// <summary>
                /// 获取或设置文字素材内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("word")]
                [System.Text.Json.Serialization.JsonPropertyName("word")]
                public string Word { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置图片素材总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int Total { get; set; }

        /// <summary>
        /// 获取或设置文字素材列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("word_list")]
        [System.Text.Json.Serialization.JsonPropertyName("word_list")]
        public Types.WordMaterial[] WordList { get; set; } = default!;
    }
}
