namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复转发消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Forwarding_of_messages_to_service_center.html </para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/introduction/custom.html#%E5%B0%86%E6%B6%88%E6%81%AF%E8%BD%AC%E5%8F%91%E5%88%B0%E5%AE%A2%E6%9C%8D </para>
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
                public string KfAccount { get; set; } = default!;
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
