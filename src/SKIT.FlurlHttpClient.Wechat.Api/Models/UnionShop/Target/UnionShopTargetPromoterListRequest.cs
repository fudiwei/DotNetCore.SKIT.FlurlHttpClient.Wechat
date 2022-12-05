namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/shop/target/promoter_list 接口的请求。</para>
    /// </summary>
    public class UnionShopTargetPromoterListRequest : WechatApiRequest, IInferable<UnionShopTargetPromoterListRequest, UnionShopTargetPromoterListResponse>
    {
        /// <summary>
        /// 获取或设置计划 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string PlanId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分页起始位置。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Offset { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Limit { get; set; }
    }
}
