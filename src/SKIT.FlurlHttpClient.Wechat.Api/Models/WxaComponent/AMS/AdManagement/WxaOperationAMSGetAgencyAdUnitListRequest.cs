namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=get_agency_ad_unit_list 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSGetAgencyAdUnitListRequest : WechatApiRequest, IInferable<WxaOperationAMSGetAgencyAdUnitListRequest, WxaOperationAMSGetAgencyAdUnitListResponse>
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
        /// 获取或设置模板广告单元 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmpl_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tmpl_id")]
        public string? TemplateId { get; set; }

        /// <summary>
        /// 获取或设置是否返回该模板广告单元 ID 绑定的商户广告单元信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_return_tmpl_bind_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("is_return_tmpl_bind_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? RequireReturnTemplateBindList { get; set; }
    }
}
