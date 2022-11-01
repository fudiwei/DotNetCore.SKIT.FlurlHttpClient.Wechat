namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/availablesoncategories/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECCategoryAvailableSonCategoriesGetRequest : WechatApiRequest, IInferable<ChannelsECCategoryAvailableSonCategoriesGetRequest, ChannelsECCategoryAvailableSonCategoriesGetResponse>
    {
        /// <summary>
        /// 获取或设置上级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("f_cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("f_cat_id")]
        public int ParentCategoryId { get; set; }
    }
}
