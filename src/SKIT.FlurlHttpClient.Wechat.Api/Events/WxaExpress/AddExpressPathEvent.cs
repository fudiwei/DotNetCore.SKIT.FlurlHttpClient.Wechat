using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.add_express_path 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/express/by-business/logistics.onPathUpdate.html </para>
    /// </summary>
    public class AddExpressPathEvent : WechatApiEvent, WechatApiEvent.Types.IJsonSerializable, WechatApiEvent.Types.IXmlSerializable
    {
        public new static class Types
        {
            public class Action
            {
                /// <summary>
                /// 获取或设置轨迹节点时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ActionTime")]
                [System.Text.Json.Serialization.JsonPropertyName("ActionTime")]
                [System.Xml.Serialization.XmlElement("ActionTime")]
                public long ActionTimestamp { get; set; }

                /// <summary>
                /// 获取或设置轨迹节点时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ActionType")]
                [System.Text.Json.Serialization.JsonPropertyName("ActionType")]
                [System.Xml.Serialization.XmlElement("ActionType")]
                public int ActionType { get; set; }

                /// <summary>
                /// 获取或设置轨迹节点详情。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ActionMsg")]
                [System.Text.Json.Serialization.JsonPropertyName("ActionMsg")]
                [System.Xml.Serialization.XmlElement("ActionMsg")]
                public string ActionMessage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置快递公司 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("DeliveryID")]
        [System.Text.Json.Serialization.JsonPropertyName("DeliveryID")]
        [System.Xml.Serialization.XmlElement("DeliveryID")]
        public string DeliveryId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商户订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OrderId")]
        [System.Text.Json.Serialization.JsonPropertyName("OrderId")]
        [System.Xml.Serialization.XmlElement("OrderId")]
        public string OrderId { get; set; } = default!;

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillId")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillId")]
        [System.Xml.Serialization.XmlElement("WayBillId")]
        public string WaybillId { get; set; } = default!;

        /// <summary>
        /// 获取或设置轨迹版本号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Version")]
        [System.Text.Json.Serialization.JsonPropertyName("Version")]
        [System.Xml.Serialization.XmlElement("Version")]
        public int Version { get; set; }

        /// <summary>
        /// 获取或设置轨迹节点数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Count")]
        [System.Text.Json.Serialization.JsonPropertyName("Count")]
        [System.Xml.Serialization.XmlElement("Count")]
        public int ActionCount { get; set; }

        /// <summary>
        /// 获取或设置轨迹列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Actions")]
        [System.Text.Json.Serialization.JsonPropertyName("Actions")]
        [System.Xml.Serialization.XmlArray("Actions")]
        public Types.Action[] ActionList { get; set; } = default!;
    }
}
