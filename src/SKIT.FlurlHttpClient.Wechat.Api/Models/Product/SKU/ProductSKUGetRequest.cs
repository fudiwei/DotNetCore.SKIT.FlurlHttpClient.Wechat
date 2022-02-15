using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/sku/get 接口的请求。</para>
    /// </summary>
    public class ProductSKUGetRequest : WechatApiRequest, IMapResponse<ProductSKUGetRequest, ProductSKUGetResponse>
    {
        /// <summary>
        /// 获取或设置 SKU ID。与字段 <see cref="OutSKUId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long? SKUId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义 SKU ID。与字段 <see cref="SKUId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
        public string? OutSKUId { get; set; }

        /// <summary>
        /// 获取或设置是否获取草稿数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_edit_sku")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_edit_sku")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? RequireEdittingSKU { get; set; }

        /// <summary>
        /// 获取或设置是否获取真实库存。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_real_stock")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("need_real_stock")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? RequireRealStock { get; set; }
    }
}
