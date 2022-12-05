using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /union/shop/target/update_promoter 接口的请求。</para>
    /// </summary>
    public class UnionShopTargetUpdatePromoterRequest : WechatApiRequest, IInferable<UnionShopTargetUpdatePromoterRequest, UnionShopTargetUpdatePromoterResponse>
    {
        /// <summary>
        /// 获取或设置计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("planId")]
        [System.Text.Json.Serialization.JsonPropertyName("planId")]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置 AppId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appidList")]
        [System.Text.Json.Serialization.JsonPropertyName("appidList")]
        public IList<string> AppIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置推客状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoterStatus")]
        [System.Text.Json.Serialization.JsonPropertyName("promoterStatus")]
        public string PromoterStatus { get; set; } = string.Empty;
    }
}
