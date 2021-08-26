using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复转发消息的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Customer_Service/Forwarding_of_messages_to_service_center.html </para>
    /// </summary>
    public class TransferCustomerServiceReply : WechatApiEvent, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Transfer
            {
                /// <summary>
                /// 获取或设置客服账号。
                /// </summary>
                [System.Xml.Serialization.XmlElement("KfAccount")]
                public string KfAccount { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置转发信息。
        /// </summary>
        [System.Xml.Serialization.XmlElement("TransInfo")]
        public Types.Transfer? Transfer { get; set; }

        public TransferCustomerServiceReply()
        {
            Event = null;
            MessageType = "transfer_customer_service";
        }
    }
}
