using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/business/novelreader/setrecmdnovel 接口的请求。</para>
    /// </summary>
    public class WxaBusinessNovelReaderSetRecommendNovelRequest : WechatApiRequest, IInferable<WxaBusinessNovelReaderSetRecommendNovelRequest, WxaBusinessNovelReaderSetRecommendNovelResponse>
    {
        /// <summary>
        /// 获取或设置推荐小说的类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recmd_type")]
        [System.Text.Json.Serialization.JsonPropertyName("recmd_type")]
        public int RecommendType { get; set; }

        /// <summary>
        /// 获取或设置作品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("book_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("book_id_list")]
        public IList<string> ChapterList { get; set; } = new List<string>();
    }
}
