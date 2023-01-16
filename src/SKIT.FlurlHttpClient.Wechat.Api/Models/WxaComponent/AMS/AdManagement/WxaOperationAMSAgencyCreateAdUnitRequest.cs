namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_create_adunit 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencyCreateAdUnitRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencyCreateAdUnitRequest, WxaOperationAMSAgencyCreateAdUnitResponse>
    {
        /// <summary>
        /// 获取或设置广告单元名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置广告单元类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

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
