namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.template_card_event 事件的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90240 </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90240 </para>
    /// </summary>
    public class TemplateCardPushEvent : WechatWorkEvent
    {
        public static class Types
        {
            public class SelectItem
            {
                public static class Types
                {
                    public class OptionIdList
                    {
                        /// <summary>
                        /// 获取或设置选项列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("OpitonId")]
                        [System.Text.Json.Serialization.JsonPropertyName("OpitonId")]
                        [System.Xml.Serialization.XmlElement("OpitonId", Type = typeof(string))]
                        public string[] Items { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置问题的 Key 值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("QuestionKey")]
                [System.Text.Json.Serialization.JsonPropertyName("QuestionKey")]
                [System.Xml.Serialization.XmlElement("QuestionKey")]
                public string QuestionKey { get; set; } = default!;

                /// <summary>
                /// 获取或设置选项 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("OpitonIds")]
                [System.Text.Json.Serialization.JsonPropertyName("OpitonIds")]
                [System.Xml.Serialization.XmlElement("OpitonIds")]
                public Types.OptionIdList OptionIdList { get; set; } = default!;
            }

            public class SelectList
            {
                /// <summary>
                /// 获取或设置下拉框列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("SelectedItem")]
                [System.Text.Json.Serialization.JsonPropertyName("SelectedItem")]
                [System.Xml.Serialization.XmlElement("SelectedItem", Type = typeof(SelectItem))]
                public SelectItem[]? Items { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AgentID")]
        [System.Text.Json.Serialization.JsonPropertyName("AgentID")]
        [System.Xml.Serialization.XmlElement("AgentID")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TaskId")]
        [System.Text.Json.Serialization.JsonPropertyName("TaskId")]
        [System.Xml.Serialization.XmlElement("TaskId")]
        public string TaskId { get; set; } = default!;

        /// <summary>
        /// 获取或设置模板卡片类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CardType")]
        [System.Text.Json.Serialization.JsonPropertyName("CardType")]
        [System.Xml.Serialization.XmlElement("CardType")]
        public string CardType { get; set; } = default!;

        /// <summary>
        /// 获取或设置用于更新卡片接口的 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResponseCode")]
        [System.Text.Json.Serialization.JsonPropertyName("ResponseCode")]
        [System.Xml.Serialization.XmlElement("ResponseCode")]
        public string ResponseCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户点击的按钮 Key 值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("EventKey")]
        [System.Text.Json.Serialization.JsonPropertyName("EventKey")]
        [System.Xml.Serialization.XmlElement("EventKey", IsNullable = true)]
        public string? ButtonKey { get; set; }

        /// <summary>
        /// 获取或设置下拉框列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SelectedItems")]
        [System.Text.Json.Serialization.JsonPropertyName("SelectedItems")]
        [System.Xml.Serialization.XmlElement("SelectedItems")]
        public Types.SelectList SelectList { get; set; } = default!;
    }
}
