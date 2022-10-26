namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.notify_third_fasteregister 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/Third-party_Platforms/2.0/api/Register_Mini_Programs/Fast_Registration_Interface_document.html </para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/register-management/fast-registration-ind/fastRegisterPersonalMp.html </para>
    /// </summary>
    public class NotifyThirdFastRegisterEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class InfoData
            {
                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [System.Xml.Serialization.XmlElement("name", IsNullable = true)]
                public string? EnterpriseName { get; set; }

                /// <summary>
                /// 获取或设置企业代码类型。
                /// </summary>
                [System.Xml.Serialization.XmlElement("code_type", IsNullable = true)]
                public int? LicenseType { get; set; }

                /// <summary>
                /// 获取或设置企业代码。
                /// </summary>
                [System.Xml.Serialization.XmlElement("code", IsNullable = true)]
                public string? LicenseNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置法人姓名。
                /// </summary>
                [System.Xml.Serialization.XmlElement("legal_persona_name", IsNullable = true)]
                public string? LegalPersonName { get; set; }

                /// <summary>
                /// 获取或设置法人微信号。
                /// </summary>
                [System.Xml.Serialization.XmlElement("legal_persona_wechat", IsNullable = true)]
                public string? LegalPersonWxname { get; set; }

                /// <summary>
                /// 获取或设置用户姓名。
                /// </summary>
                [System.Xml.Serialization.XmlElement("legal_persona_wechat", IsNullable = true)]
                public string? IdName { get; set; }

                /// <summary>
                /// 获取或设置用户微信号。
                /// </summary>
                [System.Xml.Serialization.XmlElement("wxuser", IsNullable = true)]
                public string? Wxname { get; set; }

                /// <summary>
                /// 获取或设置第三方联系电话。
                /// </summary>
                [System.Xml.Serialization.XmlElement("component_phone")]
                public string? ComponentPhoneNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置创建的小程序 AppId。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appid", IsNullable = true)]
        public string? MiniProgramAppId { get; set; }

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("auth_code", IsNullable = true)]
        public string? AuthCode { get; set; }

        /// <summary>
        /// 获取或设置消息数据。
        /// </summary>
        [System.Xml.Serialization.XmlElement("info")]
        public Types.InfoData InfoData { get; set; } = default!;

        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [System.Xml.Serialization.XmlElement("status")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置错误信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
        public string? ErrorMessage { get; set; }
    }
}
