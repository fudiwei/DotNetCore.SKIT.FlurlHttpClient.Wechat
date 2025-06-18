using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/promoter/product/parse_tag 接口的请求。</para>
    /// </summary>
    public class UnionPromoterProductParseTagRequest : WechatApiRequest, IInferable<UnionPromoterProductParseTagRequest, UnionPromoterProductParseTagResponse>
    {
        /// <summary>
        /// 获取或设置商品推广 Tag 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tagList")]
        [System.Text.Json.Serialization.JsonPropertyName("tagList")]
        public IList<string> TagList { get; set; } = new List<string>();
    }
}
