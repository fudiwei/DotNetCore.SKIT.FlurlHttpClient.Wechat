using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/update 接口的请求。</para>
    /// </summary>
    public class MerchantUpdateRequest : WechatApiRequest, IMapResponse<MerchantUpdateRequest, MerchantUpdateResponse>
    {
        public static class Types
        {
            public class Base : MerchantCreateRequest.Types.Base
            {
            }

            public class SKU : MerchantCreateRequest.Types.SKU
            {
            }

            public class AttributeExtra : MerchantCreateRequest.Types.AttributeExtra
            {
            }

            public class Delivery : MerchantCreateRequest.Types.Delivery
            {
            }
        }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public string ProductId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品基本信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_base")]
        [System.Text.Json.Serialization.JsonPropertyName("product_base")]
        public Types.Base Base { get; set; } = new Types.Base();

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_list")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_list")]
        public IList<Types.SKU>? SKUList { get; set; }

        /// <summary>
        /// 获取或设置商品其他属性。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attrext")]
        [System.Text.Json.Serialization.JsonPropertyName("attrext")]
        public Types.AttributeExtra? AttributeExtra { get; set; }

        /// <summary>
        /// 获取或设置运费信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("delivery_info")]
        [System.Text.Json.Serialization.JsonPropertyName("delivery_info")]
        public Types.Delivery? Delivery { get; set; }
    }
}
