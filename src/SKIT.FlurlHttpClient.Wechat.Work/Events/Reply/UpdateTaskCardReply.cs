namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示被动回复任务卡片更新消息的数据。</para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90241#%E4%BB%BB%E5%8A%A1%E5%8D%A1%E7%89%87%E6%9B%B4%E6%96%B0%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90377#%E4%BB%BB%E5%8A%A1%E5%8D%A1%E7%89%87%E6%9B%B4%E6%96%B0%E6%B6%88%E6%81%AF </para>
    /// <para>REF: https://developer.work.weixin.qq.com/document/path/90859#%E4%BB%BB%E5%8A%A1%E5%8D%A1%E7%89%87%E6%9B%B4%E6%96%B0%E6%B6%88%E6%81%AF </para>
    /// </summary>
    public class UpdateTaskCardReply : WechatWorkEvent
    {
        public static class Types
        {
            public class TaskCard
            {
                /// <summary>
                /// 获取或设置点击任务卡片按钮后显示的按钮名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ReplaceName")]
                [System.Text.Json.Serialization.JsonPropertyName("ReplaceName")]
                [System.Xml.Serialization.XmlElement("ReplaceName")]
                public string ReplacementText { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置任务卡片信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TaskCard")]
        [System.Text.Json.Serialization.JsonPropertyName("TaskCard")]
        [System.Xml.Serialization.XmlElement("TaskCard")]
        public Types.TaskCard? TaskCard { get; set; }

        public UpdateTaskCardReply()
        {
            Event = null;
            MessageType = "update_taskcard";
        }
    }
}
