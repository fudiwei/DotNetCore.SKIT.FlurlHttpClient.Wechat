using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /brand/profitsharing/brand-configs/{brand_mchid} 接口的响应。</para>
    /// </summary>
    public class GetBrandProfitSharingBrandConfigsResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置品牌主商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_mchid")]
        public string BrandMerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置最大分账比例（单位：万分比）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("max_ratio")]
        public int MaxRatio { get; set; }
    }
}
