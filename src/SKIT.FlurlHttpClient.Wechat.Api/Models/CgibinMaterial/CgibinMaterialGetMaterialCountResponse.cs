using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/material/get_materialcount 接口的响应。</para>
    /// </summary>
    public class CgibinMaterialGetMaterialCountResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置语音总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("voice_count")]
        [System.Text.Json.Serialization.JsonPropertyName("voice_count")]
        public int VoiceCount { get; set; }

        /// <summary>
        /// 获取或设置视频总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_count")]
        [System.Text.Json.Serialization.JsonPropertyName("video_count")]
        public int VideoCount { get; set; }

        /// <summary>
        /// 获取或设置图片总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("image_count")]
        [System.Text.Json.Serialization.JsonPropertyName("image_count")]
        public int ImageCount { get; set; }

        /// <summary>
        /// 获取或设置图文总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("news_count")]
        [System.Text.Json.Serialization.JsonPropertyName("news_count")]
        public int NewsCount { get; set; }
    }
}
