namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/product/categoryprecheck 接口的请求。</para>
    /// </summary>
    public class ChannelsECProductCategoryPrecheckRequest : WechatApiRequest, IInferable<ChannelsECProductCategoryPrecheckRequest, ChannelsECProductCategoryPrecheckResponse>
    {
        /// <summary>
        /// 获取或设置商品类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long? CategoryId { get; set; }
    }
}
