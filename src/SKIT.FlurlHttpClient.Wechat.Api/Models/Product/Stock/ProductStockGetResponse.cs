using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/stock/get 接口的响应。</para>
    /// </summary>
    public class ProductStockGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置库存。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("stock_num")]
                [System.Text.Json.Serialization.JsonPropertyName("stock_num")]
                public int Stock { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
