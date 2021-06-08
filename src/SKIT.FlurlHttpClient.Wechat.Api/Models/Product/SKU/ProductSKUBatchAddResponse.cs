using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/sku/batch_add 接口的响应。</para>
    /// </summary>
    public class ProductSKUBatchAddResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data : ProductSKUAddResponse.Types.Data
            {
                /// <summary>
                /// 获取或设置商家自定义 SKU ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_sku_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_sku_id")]
                public string OutSKUId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data[] DataList { get; set; } = default!;
    }
}
