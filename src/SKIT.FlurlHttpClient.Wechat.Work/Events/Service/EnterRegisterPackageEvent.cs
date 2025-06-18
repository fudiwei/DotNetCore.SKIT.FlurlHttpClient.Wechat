namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.enter_register_package 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90585 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/90810 ]]>
    /// </para>
    /// </summary>
    public class EnterRegisterPackageEvent : WechatWorkEvent
    {
        public static class Types
        {
            public class AuthorizerUser
            {
                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("UserId")]
                [System.Text.Json.Serialization.JsonPropertyName("UserId")]
                [System.Xml.Serialization.XmlElement("UserId")]
                public string UserId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ServiceCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("ServiceCorpId")]
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthCorpId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthCorpId")]
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置注册码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("RegisterCode")]
        [System.Text.Json.Serialization.JsonPropertyName("RegisterCode")]
        [System.Xml.Serialization.XmlElement("RegisterCode")]
        public string RegisterCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权管理员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthUserInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthUserInfo")]
        [System.Xml.Serialization.XmlElement("AuthUserInfo", IsNullable = true)]
        public Types.AuthorizerUser? AuthorizerUser { get; set; }

        /// <summary>
        /// 获取或设置推广包 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TemplateId")]
        [System.Text.Json.Serialization.JsonPropertyName("TemplateId")]
        [System.Xml.Serialization.XmlElement("TemplateId")]
        public string TemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义渠道参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("State")]
        [System.Text.Json.Serialization.JsonPropertyName("State")]
        [System.Xml.Serialization.XmlElement("State", IsNullable = true)]
        public string? State { get; set; }
    }
}
