namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getappealrecords 接口的响应。</para>
    /// </summary>
    public class WxaGetAppealRecordsResponse : WechatApiResponse
    {
        public static class Types
        {
            public class AppealRecord
            {
                public static class Types
                {
                    public class Material
                    {
                        /// <summary>
                        /// 获取或设置违规材料信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("illegal_material")]
                        [System.Text.Json.Serialization.JsonPropertyName("illegal_material")]
                        public IllegalMaterial? IllegalMaterial { get; set; }

                        /// <summary>
                        /// 获取或设置申诉材料信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appeal_material")]
                        [System.Text.Json.Serialization.JsonPropertyName("appeal_material")]
                        public AppealMaterial? AppealMaterial { get; set; }
                    }

                    public class IllegalMaterial
                    {
                        /// <summary>
                        /// 获取或设置违规内容。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content")]
                        [System.Text.Json.Serialization.JsonPropertyName("content")]
                        public string Content { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置违规链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("content_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("content_url")]
                        public string ContentUrl { get; set; } = default!;
                    }

                    public class AppealMaterial
                    {
                        /// <summary>
                        /// 获取或设置申诉理由。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reason")]
                        public string Reason { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证明材料 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("proof_material_ids")]
                        [System.Text.Json.Serialization.JsonPropertyName("proof_material_ids")]
                        public string[] ProofMediaIdList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置申诉记录 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appeal_record_id")]
                [System.Text.Json.Serialization.JsonPropertyName("appeal_record_id")]
                public int AppealRecordId { get; set; } = default!;

                /// <summary>
                /// 获取或设置申诉次数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appeal_count")]
                [System.Text.Json.Serialization.JsonPropertyName("appeal_count")]
                public int AppealCount { get; set; }

                /// <summary>
                /// 获取或设置申诉来源。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appeal_from")]
                [System.Text.Json.Serialization.JsonPropertyName("appeal_from")]
                public int AppealFrom { get; set; }

                /// <summary>
                /// 获取或设置申诉状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appeal_status")]
                [System.Text.Json.Serialization.JsonPropertyName("appeal_status")]
                public int AppealStatus { get; set; }

                /// <summary>
                /// 获取或设置申诉材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("materials")]
                [System.Text.Json.Serialization.JsonPropertyName("materials")]
                public Types.Material[]? MaterialList { get; set; }

                /// <summary>
                /// 获取或设置处罚原因描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("punish_description")]
                [System.Text.Json.Serialization.JsonPropertyName("punish_description")]
                public string? PunishDescription { get; set; }

                /// <summary>
                /// 获取或设置审核结果理由。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_reason")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
                public string? AuditReason { get; set; }

                /// <summary>
                /// 获取或设置申诉时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appeal_time")]
                [System.Text.Json.Serialization.JsonPropertyName("appeal_time")]
                public long AppealTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置申诉记录列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("records")]
        [System.Text.Json.Serialization.JsonPropertyName("records")]
        public Types.AppealRecord[] AppealRecordList { get; set; } = default!;
    }
}
