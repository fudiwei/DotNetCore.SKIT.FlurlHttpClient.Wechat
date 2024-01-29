namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.scancode_push 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Custom_Menus/Custom_Menu_Push_Events.html#2 </para>
    /// </summary>
    public class ScanCodePushEvent : WechatApiEvent
    {
        public static class Types
        {
            public class ScanCode
            {
                /// <summary>
                /// 获取或设置扫描类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ScanType")]
                [System.Text.Json.Serialization.JsonPropertyName("ScanType")]
                [System.Xml.Serialization.XmlElement("ScanType")]
                public string ScanType { get; set; } = default!;

                /// <summary>
                /// 获取或设置扫描结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ScanResult")]
                [System.Text.Json.Serialization.JsonPropertyName("ScanResult")]
                [System.Xml.Serialization.XmlElement("ScanResult")]
                public string ScanResult { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置事件 Key，即自定义菜单接口中的 Key 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventKey")]
        [System.Text.Json.Serialization.JsonPropertyName("EventKey")]
        [System.Xml.Serialization.XmlElement("EventKey")]
        public string EventKey { get; set; } = default!;

        /// <summary>
        /// 获取或设置扫描信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ScanCodeInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("ScanCodeInfo")]
        [System.Xml.Serialization.XmlElement("ScanCodeInfo")]
        public Types.ScanCode ScanCode { get; set; } = default!;
    }
}
