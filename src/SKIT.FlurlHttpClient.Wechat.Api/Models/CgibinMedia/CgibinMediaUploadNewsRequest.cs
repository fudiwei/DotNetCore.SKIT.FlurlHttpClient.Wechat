using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/uploadnews 接口的请求。</para>
    /// </summary>
    public class CgibinMediaUploadNewsRequest : WechatApiRequest
    {
        public static class Types
        {
            public class Article : CgibinMaterialAddNewsRequest.Types.Article
            {
            }
        }

        /// <summary>
        /// 获取或设置图文消息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("articles")]
        [System.Text.Json.Serialization.JsonPropertyName("articles")]
        public IList<Types.Article> ArticleList { get; set; } = new List<Types.Article>();
    }
}
