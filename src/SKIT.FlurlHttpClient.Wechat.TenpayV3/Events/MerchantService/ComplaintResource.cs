namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 COMPLAINT.CREATE 通知的数据。</para>
    /// <para>表示 COMPLAINT.STATE_CHANGE 通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/merchant/4012289719 ]]>
    /// </para>
    /// </summary>
    public class ComplaintResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置投诉单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
        public string ComplaintId { get; set; } = default!;

        /// <summary>
        /// 获取或设置动作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("action_type")]
        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
        public string ActionType { get; set; } = default!;
    }
}
