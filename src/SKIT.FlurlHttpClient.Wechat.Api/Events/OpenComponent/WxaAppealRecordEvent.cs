using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_appeal_record 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/records/record_event.html </para>
    /// </summary>
    public class WxaAppealRecordEvent : WechatApiEvent, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Material
            {
                /// <summary>
                /// 获取或设置违规材料信息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("illegal_material", IsNullable = true)]
                public IllegalMaterial? IllegalMaterial { get; set; }

                /// <summary>
                /// 获取或设置申诉材料信息。
                /// </summary>
                [System.Xml.Serialization.XmlElement("appeal_material", IsNullable = true)]
                public AppealMaterial? AppealMaterial { get; set; }
            }

            public class IllegalMaterial
            {
                /// <summary>
                /// 获取或设置违规内容。
                /// </summary>
                [System.Xml.Serialization.XmlElement("content")]
                public string Content { get; set; } = default!;

                /// <summary>
                /// 获取或设置违规链接。
                /// </summary>
                [System.Xml.Serialization.XmlElement("content_url")]
                public string ContentUrl { get; set; } = default!;
            }

            public class AppealMaterial
            {
                /// <summary>
                /// 获取或设置申诉理由。
                /// </summary>
                [System.Xml.Serialization.XmlElement("reason")]
                public string Reason { get; set; } = default!;

                /// <summary>
                /// 获取或设置证明材料 MediaId 列表。
                /// </summary>
                [System.Xml.Serialization.XmlArray("proof_material_ids")]
                public string[] ProofMediaIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置申诉记录 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appeal_record_id")]
        public int AppealRecordId { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appid")]
        public string MiniProgramAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置申诉次数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appeal_count")]
        public int AppealCount { get; set; }

        /// <summary>
        /// 获取或设置申诉来源。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appeal_from")]
        public int AppealFrom { get; set; }

        /// <summary>
        /// 获取或设置申诉状态。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appeal_status")]
        public int AppealStatus { get; set; }

        /// <summary>
        /// 获取或设置申诉材料列表。
        /// </summary>
        [System.Xml.Serialization.XmlArray("materials", IsNullable = true)]
        public Types.Material[]? MaterialList { get; set; }

        /// <summary>
        /// 获取或设置处罚原因描述。
        /// </summary>
        [System.Xml.Serialization.XmlElement("punish_description", IsNullable = true)]
        public string? PunishDescription { get; set; }

        /// <summary>
        /// 获取或设置审核结果理由。
        /// </summary>
        [System.Xml.Serialization.XmlElement("audit_reason", IsNullable = true)]
        public string? AuditReason { get; set; }

        /// <summary>
        /// 获取或设置申诉时间戳。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appeal_time")]
        public long AppealTimestamp { get; set; }
    }
}
