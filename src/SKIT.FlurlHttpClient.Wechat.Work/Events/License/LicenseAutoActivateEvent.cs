namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 INFO.auto_activate 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/95994 </para>
    /// </summary>
    public class LicenseAutoActivateEvent : WechatWorkEvent, WechatWorkEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Account
            {
                /// <summary>
                /// 获取或设置激活码。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ActiveCode")]
                public string ActiveCode { get; set; } = default!;

                /// <summary>
                /// 获取或设置类型。
                /// </summary>
                [System.Xml.Serialization.XmlElement("Type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置许可到期时间戳。
                /// </summary>
                [System.Xml.Serialization.XmlElement("ExpireTime")]
                public long ExpireTimestamp { get; set; }

                /// <summary>
                /// 获取或设置成员 UserId。
                /// </summary>
                [System.Xml.Serialization.XmlElement("UserId")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置之前的许可状态。
                /// </summary>
                [System.Xml.Serialization.XmlElement("PreviousStatus", IsNullable = true)]
                public int? PreviousStatus { get; set; }

                /// <summary>
                /// 获取或设置之前的激活码。
                /// </summary>
                [System.Xml.Serialization.XmlElement("PreviousActiveCode", IsNullable = true)]
                public string? PreviousActiveCode { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置服务商 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("ServiceCorpId")]
        public string ServiceCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置授权方的 CorpId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AuthCorpId")]
        public string AuthorizerCorpId { get; set; } = default!;

        /// <summary>
        /// 获取或设置许可自动激活场景值。
        /// </summary>
        [System.Xml.Serialization.XmlElement("Scene")]
        public int Scene { get; set; }

        /// <summary>
        /// 获取或设置激活的许可账号列表。
        /// </summary>
        [System.Xml.Serialization.XmlElement("AccountList", Type = typeof(Types.Account))]
        public Types.Account[] AccountList { get; set; } = default!;
    }
}
