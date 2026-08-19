using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/productbrandrecommend 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductBrandRecommendRequest : WechatApiRequest, IInferable<ChannelsECProductBrandRecommendRequest, ChannelsECProductBrandRecommendResponse>
    {
        /// <summary>
        /// 获取或设置商品类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 获取或设置商品头图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_imgs")]
        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
        public IList<string>? HeadImageUrlList { get; set; }

        /// <summary>
        /// 获取或设置商品详情图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("detail_imgs")]
        [System.Text.Json.Serialization.JsonPropertyName("detail_imgs")]
        public IList<string>? DetailImageUrlList { get; set; }

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;
    }
}
