namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 "EVENT.wedrive_space_change" 回调通知事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97973 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97976 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97977 ]]> <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97978 ]]>
    /// </para>
    /// </summary>
    public class WedriveSpaceChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置变更类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ChangeType")]
        [System.Text.Json.Serialization.JsonPropertyName("ChangeType")]
        [System.Xml.Serialization.XmlElement("ChangeType")]
        public string? ChangeType { get; set; }

        /// <summary>
        /// 获取或设置空间 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SpaceId")]
        [System.Text.Json.Serialization.JsonPropertyName("SpaceId")]
        [System.Xml.Serialization.XmlElement("SpaceId", Type = typeof(string))]
        public List<string>? SpaceIdList { get; set; }
    }
}
