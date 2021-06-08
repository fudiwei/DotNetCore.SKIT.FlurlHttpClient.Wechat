using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/sku/get_list 接口的响应。</para>
    /// </summary>
    public class ProductSKUGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SKU : ProductSKUGetResponse.Types.SKU
            {
            }
        }

        /// <summary>
        /// 获取或设置 SKU 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("skus")]
        [System.Text.Json.Serialization.JsonPropertyName("skus")]
        public Types.SKU[] SKUList { get; set; } = default!;
    }
}
