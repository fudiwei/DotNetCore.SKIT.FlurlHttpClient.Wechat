namespace SKIT.FlurlHttpClient.Wechat.Work.Events
{
    /// <summary>
    /// <para>表示 EVENT.kf_account_auth_change 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developer.work.weixin.qq.com/document/path/97712 ]]>
    /// </para>
    /// </summary>
    public class KfAccountAuthChangeEvent : WechatWorkEvent
    {
        /// <summary>
        /// 获取或设置新增授权的客服账号 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthAddOpenKfId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthAddOpenKfId")]
        [System.Xml.Serialization.XmlElement("AuthAddOpenKfId", Type = typeof(string), IsNullable = true)]
        public string[]? AuthAddedOpenKfId { get; set; }

        /// <summary>
        /// 获取或设置取消授权的客服账号 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("AuthDelOpenKfId")]
        [System.Text.Json.Serialization.JsonPropertyName("AuthDelOpenKfId")]
        [System.Xml.Serialization.XmlElement("AuthDelOpenKfId", Type = typeof(string), IsNullable = true)]
        public string[]? AuthDeletedOpenKfId { get; set; }
    }
}
