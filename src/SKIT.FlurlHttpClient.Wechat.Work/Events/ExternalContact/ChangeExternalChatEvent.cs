namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_external_chat 或 INFO.change_external_chat 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92130 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/92277 </para>
    /// </summary>
    public class ChangeExternalChatEvent : WechatWorkEvent
    {
        public static class Types
        {
            public class MemberChangedList
            {
                /// <summary>
                /// 获取或设置成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Item")]
                [System.Text.Json.Serialization.JsonPropertyName("Item")]
                [System.Xml.Serialization.XmlElement("Item")]
                public string[] Items { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId", IsNullable = true)]
        public string? SuiteId { get; set; }

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId", IsNullable = true)]
        public string? AuthorizerCorpId { get; set; }

        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置客户群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChatId")]
        [System.Text.Json.Serialization.JsonPropertyName("ChatId")]
        [System.Xml.Serialization.XmlElement("ChatId", IsNullable = true)]
        public string? GroupChatId { get; set; }

        /// <summary>
        /// 获取或设置客户群变更详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("UpdateDetail")]
        [System.Text.Json.Serialization.JsonPropertyName("UpdateDetail")]
        [System.Xml.Serialization.XmlElement("UpdateDetail", IsNullable = true)]
        public string? UpdateDetail { get; set; }

        /// <summary>
        /// 获取或设置客户群入群场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("JoinScene")]
        [System.Text.Json.Serialization.JsonPropertyName("JoinScene")]
        [System.Xml.Serialization.XmlElement("JoinScene", IsNullable = true)]
        public int? JoinScene { get; set; }

        /// <summary>
        /// 获取或设置客户群退群场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("QuitScene")]
        [System.Text.Json.Serialization.JsonPropertyName("QuitScene")]
        [System.Xml.Serialization.XmlElement("QuitScene", IsNullable = true)]
        public int? QuitScene { get; set; }

        /// <summary>
        /// 获取或设置成员变更数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MemChangeCnt")]
        [System.Text.Json.Serialization.JsonPropertyName("MemChangeCnt")]
        [System.Xml.Serialization.XmlElement("MemChangeCnt", IsNullable = true)]
        public int? MemberChangedCount { get; set; }

        /// <summary>
        /// 获取或设置成员变更列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("MemChangeList")]
        [System.Text.Json.Serialization.JsonPropertyName("MemChangeList")]
        [System.Xml.Serialization.XmlElement("MemChangeList", IsNullable = true)]
        public Types.MemberChangedList? MemberChangedList { get; set; }

        /// <summary>
        /// 获取或设置变更前的群成员版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("LastMemVer")]
        [System.Text.Json.Serialization.JsonPropertyName("LastMemVer")]
        [System.Xml.Serialization.XmlElement("LastMemVer", IsNullable = true)]
        public string? LastMemberVersion { get; set; }

        /// <summary>
        /// 获取或设置变更后的群成员版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CurMemVer")]
        [System.Text.Json.Serialization.JsonPropertyName("CurMemVer")]
        [System.Xml.Serialization.XmlElement("CurMemVer", IsNullable = true)]
        public string? CurrentMemberVersion { get; set; }
    }
}
