using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/account/get_brand_list 接口的响应。</para>
    /// </summary>
    public class ShopAccountGetBrandListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Brand
            {
                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                public int BrandId { get; set; }

                /// <summary>
                /// 获取或设置品牌词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_wording")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_wording")]
                public string BrandWording { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置品牌列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Brand[] BrandList { get; set; } = default!;
    }
}
