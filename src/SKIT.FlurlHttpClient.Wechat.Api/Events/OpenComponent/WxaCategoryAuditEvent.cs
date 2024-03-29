namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.wxa_category_audit 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/category-management/addCategory.html ]]>
    /// </para>
    /// </summary>
    public class WxaCategoryAuditEvent : WechatApiEvent
    {
        /// <summary>
        /// 获取或设置一级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("first")]
        [System.Text.Json.Serialization.JsonPropertyName("first")]
        [System.Xml.Serialization.XmlElement("first")]
        public int FirstCategoryId { get; set; }

        /// <summary>
        /// 获取或设置二级类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("second")]
        [System.Text.Json.Serialization.JsonPropertyName("second")]
        [System.Xml.Serialization.XmlElement("second")]
        public int SecondCategoryId { get; set; }

        /// <summary>
        /// 获取或设置审核状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret")]
        [System.Text.Json.Serialization.JsonPropertyName("ret")]
        [System.Xml.Serialization.XmlElement("ret")]
        public int AuditStatus { get; set; }

        /// <summary>
        /// 获取或设置审核拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        [System.Xml.Serialization.XmlElement("reason", IsNullable = true)]
        public string? AuditRejectReason { get; set; }
    }
}
