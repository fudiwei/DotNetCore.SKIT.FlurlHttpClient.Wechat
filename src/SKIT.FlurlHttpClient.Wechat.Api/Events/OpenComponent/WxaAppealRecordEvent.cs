namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_appeal_record 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/record-management/getAppealRecords.html ]]>
    /// </para>
    /// </summary>
    public class WxaAppealRecordEvent : WechatApiEvent
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
                [System.Xml.Serialization.XmlElement("illegal_material", IsNullable = true)]
                public IllegalMaterial? IllegalMaterial { get; set; }

                /// <summary>
                /// 获取或设置申诉材料信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appeal_material")]
                [System.Text.Json.Serialization.JsonPropertyName("appeal_material")]
                [System.Xml.Serialization.XmlElement("appeal_material", IsNullable = true)]
                public AppealMaterial? AppealMaterial { get; set; }
            }

            public class IllegalMaterial
            {
                /// <summary>
                /// 获取或设置违规内容。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content")]
                [System.Text.Json.Serialization.JsonPropertyName("content")]
                [System.Xml.Serialization.XmlElement("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置违规链接。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("content_url")]
                [System.Text.Json.Serialization.JsonPropertyName("content_url")]
                [System.Xml.Serialization.XmlElement("content_url")]
                public string ContentUrl { get; set; } = default!;
            }

            public class AppealMaterial
            {
                /// <summary>
                /// 获取或设置申诉理由。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason")]
                public string Reason { get; set; } = default!;

                /// <summary>
                /// 获取或设置证明材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("proof_material_id")]
                [System.Text.Json.Serialization.JsonPropertyName("proof_material_id")]
                [System.Xml.Serialization.XmlElement("proof_material_id", Type = typeof(string))]
                public string[] ProofMediaIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置申诉记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appeal_record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("appeal_record_id")]
        [System.Xml.Serialization.XmlElement("appeal_record_id")]
        public int AppealRecordId { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        [System.Xml.Serialization.XmlElement("appid")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申诉次数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appeal_count")]
        [System.Text.Json.Serialization.JsonPropertyName("appeal_count")]
        [System.Xml.Serialization.XmlElement("appeal_count")]
        public int AppealCount { get; set; }

        /// <summary>
        /// 获取或设置申诉来源。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appeal_from")]
        [System.Text.Json.Serialization.JsonPropertyName("appeal_from")]
        [System.Xml.Serialization.XmlElement("appeal_from")]
        public int AppealFrom { get; set; }

        /// <summary>
        /// 获取或设置申诉状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appeal_status")]
        [System.Text.Json.Serialization.JsonPropertyName("appeal_status")]
        [System.Xml.Serialization.XmlElement("appeal_status")]
        public int AppealStatus { get; set; }

        /// <summary>
        /// 获取或设置申诉材料列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material")]
        [System.Text.Json.Serialization.JsonPropertyName("material")]
        [System.Xml.Serialization.XmlElement("material", Type = typeof(Types.Material), IsNullable = true)]
        public Types.Material[]? MaterialList { get; set; }

        /// <summary>
        /// 获取或设置处罚原因描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("punish_description")]
        [System.Text.Json.Serialization.JsonPropertyName("punish_description")]
        [System.Xml.Serialization.XmlElement("punish_description", IsNullable = true)]
        public string? PunishDescription { get; set; }

        /// <summary>
        /// 获取或设置审核结果理由。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_reason")]
        [System.Xml.Serialization.XmlElement("audit_reason", IsNullable = true)]
        public string? AuditReason { get; set; }

        /// <summary>
        /// 获取或设置申诉时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appeal_time")]
        [System.Text.Json.Serialization.JsonPropertyName("appeal_time")]
        [System.Xml.Serialization.XmlElement("appeal_time")]
        public long AppealTimestamp { get; set; }
    }
}
