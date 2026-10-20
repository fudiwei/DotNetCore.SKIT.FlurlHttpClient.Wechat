namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_set_cover_adpos_scene 接口的请求。</para>
    /// </summary>
    public class WxaOperationAMSAgencySetCoverAdPositionSceneRequest : WechatApiRequest, IInferable<WxaOperationAMSAgencySetCoverAdPositionSceneRequest, WxaOperationAMSAgencySetCoverAdPositionSceneResponse>
    {
        /// <summary>
        /// 获取或设置封面场景值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_scene_list")]
        [Newtonsoft.Json.JsonConverter(typeof(SKIT.JsonConv.NewtonsoftJson.Converters.StringifiedNumberListWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("cover_scene_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberListWithCommaSplitConverter))]
        public IList<int> CoverSceneList { get; set; } = new List<int>();
    }
}
