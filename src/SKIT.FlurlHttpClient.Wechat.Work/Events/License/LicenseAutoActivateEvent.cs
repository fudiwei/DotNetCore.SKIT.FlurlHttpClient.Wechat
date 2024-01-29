namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.auto_activate 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/95994 </para>
    /// </summary>
    public class LicenseAutoActivateEvent : WechatWorkEvent
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ActiveCode")]
                [System.Text.Json.Serialization.JsonPropertyName("ActiveCode")]
                [System.Xml.Serialization.XmlElement("ActiveCode")]
                public string ActiveCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("Type")]
                [System.Text.Json.Serialization.JsonPropertyName("Type")]
                [System.Xml.Serialization.XmlElement("Type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置许可到期时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ExpireTime")]
                [System.Text.Json.Serialization.JsonPropertyName("ExpireTime")]
                [System.Xml.Serialization.XmlElement("ExpireTime")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("UserId")]
                [System.Text.Json.Serialization.JsonPropertyName("UserId")]
                [System.Xml.Serialization.XmlElement("UserId")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置之前的许可状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PreviousStatus")]
                [System.Text.Json.Serialization.JsonPropertyName("PreviousStatus")]
                [System.Xml.Serialization.XmlElement("PreviousStatus", IsNullable = true)]
                public int? PreviousStatus { get; set; }

                /// <summary>
                /// 获取或设置之前的激活码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("PreviousActiveCode")]
                [System.Text.Json.Serialization.JsonPropertyName("PreviousActiveCode")]
                [System.Xml.Serialization.XmlElement("PreviousActiveCode", IsNullable = true)]
                public string? PreviousActiveCode { get; set; }
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
        /// 获取或设置许可自动激活场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Scene")]
        [System.Text.Json.Serialization.JsonPropertyName("Scene")]
        [System.Xml.Serialization.XmlElement("Scene")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置激活的许可账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AccountList")]
        [System.Text.Json.Serialization.JsonPropertyName("AccountList")]
        [System.Xml.Serialization.XmlElement("AccountList", Type = typeof(Types.Account))]
        public Types.Account[] AccountList { get; set; } = default!;
    }
}
