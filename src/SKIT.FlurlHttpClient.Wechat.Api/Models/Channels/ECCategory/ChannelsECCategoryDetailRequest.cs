namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/detail 接口的请求。</para>
    /// </summary>
    public class ChannelsECCategoryDetailRequest : WechatApiRequest, IInferable<ChannelsECCategoryDetailRequest, ChannelsECCategoryDetailResponse>
    {
        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cat_id")]
        public long CategoryId { get; set; }
    }
}
