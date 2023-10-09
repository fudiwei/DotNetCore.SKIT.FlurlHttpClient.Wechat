namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.change_auth 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90642 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/99401 </para>
    /// </summary>
    public class ChangeAuthEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Extra
            {
                public static class Types
                {
                    public class AuthorizedOpenKfIdList
                    {
                        /// <summary>
                        /// 获取或设置客服账号列表。
                        /// </summary>
                        [System.Xml.Serialization.XmlElement("OpenKfId", Type = typeof(string))]
                        public string[] Items { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置用户本次授权的客服账号列表。
                /// </summary>
                [System.Xml.Serialization.XmlElement("AuthOpenKfIdList", IsNullable = true)]
                public Types.AuthorizedOpenKfIdList? AuthorizedOpenKfIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ExtraInfo", IsNullable = true)]
        public Types.Extra? Extra { get; set; }
    }
}
