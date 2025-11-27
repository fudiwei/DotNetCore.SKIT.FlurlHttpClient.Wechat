namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/headsupplier/secondheadsupplieritem/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECLeagueHeadSupplierSecondHeadSupplierItemAddRequest : WechatApiRequest, IInferable<ChannelsECLeagueHeadSupplierSecondHeadSupplierItemAddRequest, ChannelsECLeagueHeadSupplierSecondHeadSupplierItemAddResponse>
    {
        /// <summary>
        /// 获取或设置机构合作计划 ID。与字段 <see cref="HeadSupplierItemLink"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cooperative_item_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cooperative_item_id")]
        public long? CooperativeItemId { get; set; }

        /// <summary>
        /// 获取或设置机构推广商品链接。与字段 <see cref="CooperativeItemId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_supplier_item_link")]
        [System.Text.Json.Serialization.JsonPropertyName("head_supplier_item_link")]
        public string? HeadSupplierItemLink { get; set; }

        /// <summary>
        /// 获取或设置计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_type")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        public int PlanType { get; set; }

        /// <summary>
        /// 获取或设置商品帮卖服务费率（单位：万分数）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_ratio")]
        [System.Text.Json.Serialization.JsonPropertyName("service_ratio")]
        public int ServiceRatio { get; set; }

        /// <summary>
        /// 获取或设置定向的机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_head_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("to_head_supplier_appid")]
        public string? ToHeadSupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置开始时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_time")]
        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public long? StartTimestamp { get; set; }

        /// <summary>
        /// 获取或设置结束时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_time")]
        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public long? EndTimestamp { get; set; }
    }
}
