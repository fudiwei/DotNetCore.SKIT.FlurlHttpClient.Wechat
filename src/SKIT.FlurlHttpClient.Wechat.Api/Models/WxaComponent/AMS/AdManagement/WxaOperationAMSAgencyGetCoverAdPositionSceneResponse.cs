namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/operationams?action=agency_get_cover_adpos_scene 接口的响应。</para>
    /// </summary>
    public class WxaOperationAMSAgencyGetCoverAdPositionSceneResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置返回错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置返回错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public string? ReturnMessage { get; set; }

        /// <summary>
        /// 获取或设置封面场景值列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_scene_list")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.StringifiedNumberArrayWithCommaSplitConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("cover_scene_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.StringifiedNumberArrayWithCommaSplitConverter))]
        public int[] CoverSceneList { get; set; } = default!;

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && ReturnCode == 0;
        }
    }
}
