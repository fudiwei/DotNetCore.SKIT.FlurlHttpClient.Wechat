namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_update_adunit 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencyUpdateAdUnitRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencyUpdateAdUnitRequest, WxaOperationAMSAgencyUpdateAdUnitResponse>
    {
        /// <summary>
        /// 获取或设置广告单元 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ad_unit_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ad_unit_id")]
        public string AdUnitId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告单元名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告单元开关状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告展示时长最小值（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_duration_min")]
        [System.Text.Json.Serialization.JsonPropertyName("video_duration_min")]
        public int? MinVideoDuration { get; set; }

        /// <summary>
        /// 获取或设置广告展示时长最大值（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("video_duration_max")]
        [System.Text.Json.Serialization.JsonPropertyName("video_duration_max")]
        public int? MaxVideoDuration { get; set; }

        /// <summary>
        /// 获取或设置模板类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmpl_type")]
        [System.Text.Json.Serialization.JsonPropertyName("tmpl_type")]
        public int? TemplateType { get; set; }

        /// <summary>
        /// 获取或设置模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tmpl_id")]
        [System.Text.Json.Serialization.JsonPropertyName("tmpl_id")]
        public string? TemplateId { get; set; }
    }
}
