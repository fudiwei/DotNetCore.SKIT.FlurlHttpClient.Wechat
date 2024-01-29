namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 INFO.notify_third_fasteregister 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/register-management/fast-registration-ent/registerMiniprogram.html </para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/register-management/fast-registration-ind/fastRegisterPersonalMp.html </para>
    /// </summary>
    public class NotifyThirdFastRegisterEvent : WechatApiEvent
    {
        public static class Types
        {
            public class InfoData
            {
                /// <summary>
                /// 获取或设置企业名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [System.Xml.Serialization.XmlElement("name", IsNullable = true)]
                public string? EnterpriseName { get; set; }

                /// <summary>
                /// 获取或设置企业代码类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code_type")]
                [System.Text.Json.Serialization.JsonPropertyName("code_type")]
                [System.Xml.Serialization.XmlElement("code_type", IsNullable = true)]
                public int? LicenseType { get; set; }

                /// <summary>
                /// 获取或设置企业代码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("code")]
                [System.Text.Json.Serialization.JsonPropertyName("code")]
                [System.Xml.Serialization.XmlElement("code", IsNullable = true)]
                public string? LicenseNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置法人姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_persona_name")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_persona_name")]
                [System.Xml.Serialization.XmlElement("legal_persona_name", IsNullable = true)]
                public string? LegalPersonName { get; set; }

                /// <summary>
                /// 获取或设置法人微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_persona_wechat")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_persona_wechat")]
                [System.Xml.Serialization.XmlElement("legal_persona_wechat", IsNullable = true)]
                public string? LegalPersonWxname { get; set; }

                /// <summary>
                /// 获取或设置用户姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("idname")]
                [System.Text.Json.Serialization.JsonPropertyName("idname")]
                [System.Xml.Serialization.XmlElement("idname", IsNullable = true)]
                public string? IdName { get; set; }

                /// <summary>
                /// 获取或设置用户微信号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("wxuser")]
                [System.Text.Json.Serialization.JsonPropertyName("wxuser")]
                [System.Xml.Serialization.XmlElement("wxuser", IsNullable = true)]
                public string? Wxname { get; set; }

                /// <summary>
                /// 获取或设置第三方联系电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("component_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("component_phone")]
                [System.Xml.Serialization.XmlElement("component_phone")]
                public string? ComponentPhoneNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置创建的小程序 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        [System.Xml.Serialization.XmlElement("appid", IsNullable = true)]
        public string? MiniProgramAppId { get; set; }

        /// <summary>
        /// 获取或设置授权码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auth_code")]
        [System.Text.Json.Serialization.JsonPropertyName("auth_code")]
        [System.Xml.Serialization.XmlElement("auth_code", IsNullable = true)]
        public string? AuthCode { get; set; }

        /// <summary>
        /// 获取或设置消息数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        [System.Xml.Serialization.XmlElement("info")]
        public Types.InfoData InfoData { get; set; } = default!;

        /// <summary>
        /// 获取或设置错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        [System.Xml.Serialization.XmlElement("status")]
        public int ErrorCode { get; set; }

        /// <summary>
        /// 获取或设置错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        [System.Xml.Serialization.XmlElement("msg", IsNullable = true)]
        public string? ErrorMessage { get; set; }
    }
}
