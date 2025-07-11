using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/category/availablesoncategories/get 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-07-01 下线。")]
    public class ChannelsECCategoryAvailableSonCategoriesGetRequest : WechatApiRequest, IInferable<ChannelsECCategoryAvailableSonCategoriesGetRequest, ChannelsECCategoryAvailableSonCategoriesGetResponse>
    {
        /// <summary>
        /// 获取或设置上级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("f_cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("f_cat_id")]
        public long ParentCategoryId { get; set; }
    }
}
