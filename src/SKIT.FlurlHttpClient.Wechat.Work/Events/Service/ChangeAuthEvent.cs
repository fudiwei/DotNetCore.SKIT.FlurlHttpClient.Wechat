namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.change_auth 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90642 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/99401 </para>
    /// </summary>
    public class ChangeAuthEvent : WechatWorkEvent
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
                        [Newtonsoft.Json.JsonProperty("OpenKfId")]
                        [System.Text.Json.Serialization.JsonPropertyName("OpenKfId")]
                        [System.Xml.Serialization.XmlElement("OpenKfId", Type = typeof(string))]
                        public string[] Items { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置用户本次授权的客服账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("AuthOpenKfIdList")]
                [System.Text.Json.Serialization.JsonPropertyName("AuthOpenKfIdList")]
                [System.Xml.Serialization.XmlElement("AuthOpenKfIdList", IsNullable = true)]
                public Types.AuthorizedOpenKfIdList? AuthorizedOpenKfIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置第三方应用的 SuiteId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SuiteId")]
        [System.Text.Json.Serialization.JsonPropertyName("SuiteId")]
        [System.Xml.Serialization.XmlElement("SuiteId")]
        public string SuiteId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置事件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ExtraInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("ExtraInfo")]
        [System.Xml.Serialization.XmlElement("ExtraInfo", IsNullable = true)]
        public Types.Extra? Extra { get; set; }
    }
}
