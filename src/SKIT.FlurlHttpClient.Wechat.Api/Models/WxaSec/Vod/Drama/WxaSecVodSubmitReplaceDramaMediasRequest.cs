using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/submitreplacedramamedias 接口的请求。</para>
    /// </summary>
    public class WxaSecVodSubmitReplaceDramaMediasRequest : WechatApiRequest, IInferable<WxaSecVodSubmitReplaceDramaMediasRequest, WxaSecVodSubmitReplaceDramaMediasResponse>
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
        /// 获取或设置替换的剧集信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replace_media_list")]
        [System.Text.Json.Serialization.JsonPropertyName("replace_media_list")]
        public IList<Types.ReplaceMedia>? ReplaceMediaList { get; set; }
    }
}
