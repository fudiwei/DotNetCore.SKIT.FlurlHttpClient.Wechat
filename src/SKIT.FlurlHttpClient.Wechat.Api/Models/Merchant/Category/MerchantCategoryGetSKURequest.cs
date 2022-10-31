using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/category/getsku 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantCategoryGetSKURequest : WechatApiRequest, IInferable<MerchantCategoryGetSKURequest, MerchantCategoryGetSKUResponse>
    {
        /// <summary>
        /// 获取或设置商品分类 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cate_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cate_id")]
        public string CategoryId { get; set; } = string.Empty;
    }
}
