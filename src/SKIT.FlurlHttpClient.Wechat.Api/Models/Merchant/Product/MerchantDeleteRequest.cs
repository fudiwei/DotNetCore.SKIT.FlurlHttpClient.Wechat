using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/del 接口的请求。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2020-10-01 下线。")]
    public class MerchantDeleteRequest : WechatApiRequest, IInferable<MerchantDeleteRequest, MerchantDeleteResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;
    }
}
