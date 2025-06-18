﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/del 接口的请求。</para>
    /// </summary>
    public class ProductSPUDeleteRequest : WechatApiRequest, IInferable<ProductSPUDeleteRequest, ProductSPUDeleteResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。与字段 <see cref="OutProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义商品 ID。与字段 <see cref="ProductId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_product_id")]
        public string? OutProductId { get; set; }
    }
}
