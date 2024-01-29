namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.withdraw_notify 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/withdraw_notify.html </para>
    /// </summary>
    public class WithdrawNotifyEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Withdraw
            {
                /// <summary>
                /// 获取或设置商户提现单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_request_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_request_no")]
                [System.Xml.Serialization.XmlElement("out_request_no")]
                public string OutRequestNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置提现结果事件类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("event")]
                [System.Text.Json.Serialization.JsonPropertyName("event")]
                [System.Xml.Serialization.XmlElement("event")]
                public int EventType { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置提现信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_info")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_info")]
        [System.Xml.Serialization.XmlElement("withdraw_info")]
        public Types.Withdraw Withdraw { get; set; } = default!;
    }
}
