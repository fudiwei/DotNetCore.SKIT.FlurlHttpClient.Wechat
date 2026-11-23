namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/component/createappeal 接口的请求。</para>
    /// </summary>
    public class WxaComponentCreateAppealRequest : WechatApiRequest, IInferable<WxaComponentCreateAppealRequest, WxaComponentCreateAppealResponse>
    {
        public static class Types
        {
            public class AppealMaterial
            {
                /// <summary>
                /// 获取或设置申诉理由。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string? Reason { get; set; }

                /// <summary>
                /// 获取或设置证明材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("proof_material_ids")]
                [System.Text.Json.Serialization.JsonPropertyName("proof_material_ids")]
                public List<string>? ProofMediaIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置违规处罚记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("illegal_record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("illegal_record_id")]
        public string? IllegalRecordId { get; set; }

        /// <summary>
        /// 获取或设置申诉材料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appeal_materials")]
        [System.Text.Json.Serialization.JsonPropertyName("appeal_materials")]
        public List<Types.AppealMaterial>? AppealMaterialList { get; set; }
    }
}
