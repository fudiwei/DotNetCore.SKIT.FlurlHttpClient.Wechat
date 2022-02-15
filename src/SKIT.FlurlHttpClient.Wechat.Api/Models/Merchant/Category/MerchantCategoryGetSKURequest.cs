using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/category/getsku 接口的请求。</para>
    /// </summary>
    public class MerchantCategoryGetSKURequest : WechatApiRequest, IMapResponse<MerchantCategoryGetSKURequest, MerchantCategoryGetSKUResponse>
    {
        /// <summary>
        /// 获取或设置商品分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cate_id")]
        public string CategoryId { get; set; } = string.Empty;
    }
}
