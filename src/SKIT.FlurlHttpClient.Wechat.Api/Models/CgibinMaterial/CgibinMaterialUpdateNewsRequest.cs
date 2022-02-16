using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/update_news 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-02-25 下线。")]
    public class CgibinMaterialUpdateNewsRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Article : CgibinMaterialAddNewsRequest.Types.Article
            {
            }
        }

        /// <summary>
        /// 获取或设置媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置要更新的文章在图文消息中的位置（从 0 开始）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("index")]
        [System.Text.Json.Serialization.JsonPropertyName("index")]
        public int Index { get; set; }

        /// <summary>
        /// 获取或设置要更新的图文消息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("articles")]
        [System.Text.Json.Serialization.JsonPropertyName("articles")]
        public Types.Article Article { get; set; } = new Types.Article();
    }
}
