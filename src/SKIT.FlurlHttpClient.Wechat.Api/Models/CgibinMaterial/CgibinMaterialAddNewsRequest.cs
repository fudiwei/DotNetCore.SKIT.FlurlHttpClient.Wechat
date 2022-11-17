using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/add_news 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2022-02-25 下线。")]
    public class CgibinMaterialAddNewsRequest : WechatApiRequest, IInferable<CgibinMaterialAddNewsRequest, CgibinMaterialAddNewsResponse>
    {
        public static class Types
        {
            public class Article : CgibinMediaUploadNewsRequest.Types.Article
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
