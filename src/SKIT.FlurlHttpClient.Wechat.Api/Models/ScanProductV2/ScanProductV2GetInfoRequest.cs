using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /scan/product/v2/getinfo 接口的请求。</para>
    /// </summary>
    public class ScanProductV2GetInfoRequest : WechatApiRequest, IMapResponse<ScanProductV2GetInfoRequest, ScanProductV2GetInfoResponse>
    {
        public static class Types
        {
            public class Product
            {
                /// <summary>
                /// 获取或设置商品 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pid")]
                [System.Text.Json.Serialization.JsonPropertyName("pid")]
                public string ProductId { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product")]
        [System.Text.Json.Serialization.JsonPropertyName("product")]
        public Types.Product Product { get; set; } = new Types.Product();
    }
}
