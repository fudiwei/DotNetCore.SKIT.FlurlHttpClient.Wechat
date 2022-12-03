namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.change_chain 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/95796 </para>
    /// </summary>
    public class ChangeChainEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class GroupIdList
            {
                /// <summary>
                /// 获取或设置分组 ID 列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("GroupId", Type = typeof(int))]
                public int[] Items { get; set; } = default!;
            }

            public class CorpIdList
            {
                /// <summary>
                /// 获取或设置企业 ID 列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("CorpId", Type = typeof(string))]
                public string[] Items { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string ChangeType { get; set; } = default!;

        /// <summary>
        /// 获取或设置上下游 ID。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ChainId")]
        public string ChainId { get; set; } = default!;

        /// <summary>
        /// 获取或设置分组 ID 列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("GroupIds", IsNullable = true)]
        public Types.GroupIdList? GroupIdList { get; set; }

        /// <summary>
        /// 获取或设置企业 ID 列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("CorpIds", IsNullable = true)]
        public Types.CorpIdList? CorpIdList { get; set; }
    }
}
