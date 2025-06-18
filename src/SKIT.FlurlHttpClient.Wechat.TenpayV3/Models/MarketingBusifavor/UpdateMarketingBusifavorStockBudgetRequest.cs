namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /marketing/busifavor/stocks/{stock_id}/budget 接口的请求。</para>
    /// </summary>
    public class UpdateMarketingBusifavorStockBudgetRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置批次号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置目标批次最大发放个数。与字段 <see cref="TargetMaxCouponsPerDay"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_max_coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("target_max_coupons")]
        public int? TargetMaxCoupons { get; set; }

        /// <summary>
        /// 获取或设置目标单天发放上限个数。与字段 <see cref="TargetMaxCoupons"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target_max_coupons_by_day")]
        [System.Text.Json.Serialization.JsonPropertyName("target_max_coupons_by_day")]
        public int? TargetMaxCouponsPerDay { get; set; }

        /// <summary>
        /// 获取或设置当前单天发放上限个数。与字段 <see cref="CurrentMaxCouponsPerDay"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_max_coupons")]
        [System.Text.Json.Serialization.JsonPropertyName("current_max_coupons")]
        public int? CurrentMaxCoupons { get; set; }

        /// <summary>
        /// 获取或设置目标单天发放上限个数。与字段 <see cref="CurrentMaxCoupons"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("current_max_coupons_by_day")]
        [System.Text.Json.Serialization.JsonPropertyName("current_max_coupons_by_day")]
        public int? CurrentMaxCouponsPerDay { get; set; }

        /// <summary>
        /// 获取或设置商户请求单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("modify_budget_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("modify_budget_request_no")]
        public string OutRequestNumber { get; set; } = string.Empty;
    }
}
