using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/category/get 接口的请求。</para>
    /// </summary>
    public class ProductCategoryGetRequest : WechatApiRequest, IMapResponse<ProductCategoryGetRequest, ProductCategoryGetResponse>
    {
        /// <summary>
        /// 获取或设置上级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("f_cat_id")]
        [System.Text.Json.Serialization.JsonPropertyName("f_cat_id")]
        public int ParentCategoryId { get; set; }
    }
}
