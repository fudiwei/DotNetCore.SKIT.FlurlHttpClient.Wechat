using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /profitsharing/merchant-configs/{sub_mchid} 接口的响应。</para>
    /// </summary>
    public class GetProfitSharingMerchantConfigsResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置最大分账比例（单位：万分比）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("max_ratio")]
        public int MaxRatio { get; set; }
    }
}
