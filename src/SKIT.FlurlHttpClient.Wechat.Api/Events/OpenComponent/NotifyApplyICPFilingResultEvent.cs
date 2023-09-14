namespace SKIT.FlurlHttpClient.Wechat.Api.Events.OpenComponent
{
    /// <summary>
    /// <para>表示 INFO.notify_apply_icpfiling_result 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/oplatform/openApi/OpenApiDoc/miniprogram-management/record/applyIcpFiling.html#%E4%BA%8B%E4%BB%B6%E6%8E%A8%E9%80%81 </para>
    /// </summary>
    public class NotifyApplyICPFilingResultEvent : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置授权方 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorizer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("authorizer_appid")]
        [System.Xml.Serialization.XmlElement("authorizer_appid")]
        public string AuthorizerAppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置备案状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("beian_status")]
        [System.Text.Json.Serialization.JsonPropertyName("beian_status")]
        [System.Xml.Serialization.XmlElement("beian_status")]
        public int FilingStatus { get; set; }
    }
}
