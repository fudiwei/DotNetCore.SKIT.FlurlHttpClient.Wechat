namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/shop/target/product_list 接口的请求。</para>
    /// </summary>
    public class UnionShopTargetProductListRequest : WechatApiRequest, IInferable<UnionShopTargetProductListRequest, UnionShopTargetProductListResponse>
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
