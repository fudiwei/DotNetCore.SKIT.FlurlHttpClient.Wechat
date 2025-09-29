using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/category/classify 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductCategoryClassifyRequest : WechatApiRequest, IInferable<ChannelsECProductCategoryClassifyRequest, ChannelsECProductCategoryClassifyResponse>
    {
        /// <summary>
        /// 获取或设置请求类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("req_type")]
        [System.Text.Json.Serialization.JsonPropertyName("req_type")]
        public int RequestType { get; set; }

        /// <summary>
        /// 获取或设置商品标题。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品主图 URL 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_imgs")]
        [System.Text.Json.Serialization.JsonPropertyName("head_imgs")]
        public IList<string> HeadImageUrlList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置商品类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long? CategoryId { get; set; }
    }
}
