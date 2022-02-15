using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/sku/get_list 接口的请求。</para>
    /// </summary>
    public class ProductSKUGetListRequest : WechatApiRequest, IMapResponse<ProductSKUGetListRequest, ProductSKUGetListResponse>
    {
        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

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
