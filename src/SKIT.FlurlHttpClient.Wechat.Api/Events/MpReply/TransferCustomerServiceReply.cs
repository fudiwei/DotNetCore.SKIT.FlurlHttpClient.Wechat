namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 "transfer_customer_service" 回调通知应答的数据</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/doc/service/guide/product/kf/forwarding.html ]]> <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/introduction/custom.html ]]>
    /// </para>
    /// </summary>
    public class TransferCustomerServiceReply : WechatApiEvent
    {
        public static class Types
        {
            public class Transfer
            {
                /// <summary>
                /// 获取或设置客服账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("KfAccount")]
                [System.Text.Json.Serialization.JsonPropertyName("KfAccount")]
                [System.Xml.Serialization.XmlElement("KfAccount")]
                public string? KfAccount { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置转发信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TransInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("TransInfo")]
        [System.Xml.Serialization.XmlElement("TransInfo")]
        public Types.Transfer? Transfer { get; set; }

        public TransferCustomerServiceReply()
        {
            MessageType = "transfer_customer_service";
            Event = null;
        }
    }
}
