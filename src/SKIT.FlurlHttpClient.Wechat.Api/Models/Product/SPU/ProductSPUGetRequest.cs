﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/spu/get 接口的请求。</para>
    /// </summary>
    public class ProductSPUGetRequest : WechatApiRequest, IInferable<ProductSPUGetRequest, ProductSPUGetResponse>
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

        /// <summary>
        /// 获取或设置是否获取草稿数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_edit_spu")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_edit_spu")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? RequireEdittingSPU { get; set; }
    }
}
