namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/busifavor/stocks/{stock_id}/budget 接口的响应。</para>
    /// </summary>
    public class UpdateMarketingBusifavorStockBudgetResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置当前最大发放个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("max_coupons")]
        public int MaxCoupons { get; set; }

        /// <summary>
        /// 获取或设置当前单天发放上限个数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("max_coupons_by_day")]
        [System.Text.Json.Serialization.JsonPropertyName("max_coupons_by_day")]
        public int? MaxCouponsPerDay { get; set; }
    }
}
