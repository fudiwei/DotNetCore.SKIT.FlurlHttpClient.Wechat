namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_adunit_list 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetAdUnitListRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencyGetAdUnitListRequest, WxaOperationAMSAgencyGetAdUnitListResponse>
    {
        /// <summary>
        /// 获取或设置分页页数。
        /// <para>默认值：1</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page")]
        [System.Text.Json.Serialization.JsonPropertyName("page")]
        public int Page { get; set; } = 1;

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置广告位类型名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_slot")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_slot")]
        public string? AdSlot { get; set; }

        /// <summary>
        /// 获取或设置广告单元 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_unit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_unit_id")]
        public string? AdUnitId { get; set; }
    }
}
