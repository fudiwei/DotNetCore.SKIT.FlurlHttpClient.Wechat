using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/replacedramamedia 接口的请求。</para>
    /// </summary>
    public class WxaSecVodReplaceDramaMediaRequest : WechatApiRequest, IInferable<WxaSecVodReplaceDramaMediaRequest, WxaSecVodReplaceDramaMediaResponse>
    {
        public static class Types
        {
            public class ReplaceMedia : WxaSecVodAuditDramaRequest.Types.ReplaceMedia
            {
            }
        }
    
        /// <summary>
        /// 获取或设置剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        public long DramaId { get; set; }

        /// <summary>
        /// 获取或设置旧媒资文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("old_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("old_media_id")]
        public long OldMediaId { get; set; }

        /// <summary>
        /// 获取或设置新媒资文件 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("new_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("new_media_id")]
        public long NewMediaId { get; set; }
    }
}
