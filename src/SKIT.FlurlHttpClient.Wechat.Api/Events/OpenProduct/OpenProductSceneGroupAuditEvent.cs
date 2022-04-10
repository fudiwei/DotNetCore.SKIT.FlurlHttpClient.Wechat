namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.open_product_scene_group_audit 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/scene_group_audit.html </para>
    /// </summary>
    public class OpenProductSceneGroupAuditEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class EventData
            {
                public static class Types
                {
                    public class SceneGroupExtra
                    {
                        /// <summary>
                        /// 获取或设置审核项目 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ext_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("ext_id")]
                        [System.Xml.Serialization.XmlElement("ext_id")]
                        public int ExtraId { get; set; }

                        /// <summary>
                        /// 获取或设置审核项目名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        [System.Xml.Serialization.XmlElement("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置审核结果。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        [System.Xml.Serialization.XmlElement("status")]
                        public int Status { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置场景 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("group_id")]
                [System.Text.Json.Serialization.JsonPropertyName("group_id")]
                [System.Xml.Serialization.XmlElement("group_id")]
                public int GroupId { get; set; }

                /// <summary>
                /// 获取或设置场景名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [System.Xml.Serialization.XmlElement("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核文案。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
                public string? Reason { get; set; }

                /// <summary>
                /// 获取或设置场景审核结果列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene_group_ext_list")]
                [System.Text.Json.Serialization.JsonPropertyName("scene_group_ext_list")]
                [System.Xml.Serialization.XmlArrayItem("scene_group_ext_list", Type = typeof(Types.SceneGroupExtra))]
                public Types.SceneGroupExtra[] SceneGroupExtraList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SceneGroupAudit")]
        [System.Text.Json.Serialization.JsonPropertyName("SceneGroupAudit")]
        [System.Xml.Serialization.XmlElement("SceneGroupAudit")]
        public Types.EventData EventData { get; set; } = default!;
    }
}
