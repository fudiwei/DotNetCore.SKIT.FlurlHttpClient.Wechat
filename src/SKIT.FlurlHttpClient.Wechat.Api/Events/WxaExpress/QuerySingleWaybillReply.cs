namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示回复 EVENT.query_single_waybill 事件的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/industry/express/delivery/single-delivery.html ]]>
    /// </para>
    /// </summary>
    public class QuerySingleWaybillReply : WechatApiEvent
    {
        public static class Types
        {
            public class Sender : AddSingleWaybillEvent.Types.Sender
            {
            }

            public class Receiver : AddSingleWaybillEvent.Types.Receiver
            {
            }

            public class Cargo : AddSingleWaybillEvent.Types.Cargo
            {
            }

            public class Insurance : AddSingleWaybillEvent.Types.Insurance
            {
            }

            public class Path
            {
                public static class Types
                {
                    public class PathAction
                    {
                        /// <summary>
                        /// 获取或设置轨迹节点时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_time")]
                        [System.Xml.Serialization.XmlElement("action_time")]
                        public long ActionTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置轨迹节点类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_type")]
                        [System.Xml.Serialization.XmlElement("action_type")]
                        public int ActionType { get; set; }

                        /// <summary>
                        /// 获取或设置轨迹节点详情。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("action_msg")]
                        [System.Text.Json.Serialization.JsonPropertyName("action_msg")]
                        [System.Xml.Serialization.XmlElement("action_msg")]
                        public string ActionMessage { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置取件员姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pickup_courier_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("pickup_courier_name")]
                        [System.Xml.Serialization.XmlElement("pickup_courier_name", IsNullable = true)]
                        public string? PickupCourierName { get; set; }

                        /// <summary>
                        /// 获取或设置取件员电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pickup_courier_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("pickup_courier_phone")]
                        [System.Xml.Serialization.XmlElement("pickup_courier_phone", IsNullable = true)]
                        public string? PickupCourierPhoneNumber { get; set; }

                        /// <summary>
                        /// 获取或设置派件员姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_courier_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_courier_name")]
                        [System.Xml.Serialization.XmlElement("delivery_courier_name", IsNullable = true)]
                        public string? DeliveryCourierName { get; set; }

                        /// <summary>
                        /// 获取或设置派件员电话号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_courier_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_courier_phone")]
                        [System.Xml.Serialization.XmlElement("delivery_courier_phone", IsNullable = true)]
                        public string? DeliveryCourierPhoneNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置轨迹节点列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path_info")]
                [System.Text.Json.Serialization.JsonPropertyName("path_info")]
                [System.Xml.Serialization.XmlElement("path_info", Type = typeof(Types.PathAction))]
                public Types.PathAction[] PathActionList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置处理结果错误码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultCode")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultCode")]
        [System.Xml.Serialization.XmlElement("ResultCode")]
        public int ResultCode { get; set; }

        /// <summary>
        /// 获取或设置处理结果错误信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ResultMsg")]
        [System.Text.Json.Serialization.JsonPropertyName("ResultMsg")]
        [System.Xml.Serialization.XmlElement("ResultMsg", IsNullable = true)]
        public string? ResultMessage { get; set; }

        /// <summary>
        /// 获取或设置运单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("WayBillID")]
        [System.Text.Json.Serialization.JsonPropertyName("WayBillID")]
        [System.Xml.Serialization.XmlElement("WayBillID", IsNullable = true)]
        public string? WaybillId { get; set; }

        /// <summary>
        /// 获取或设置发件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Sender")]
        [System.Text.Json.Serialization.JsonPropertyName("Sender")]
        [System.Xml.Serialization.XmlElement("Sender")]
        public Types.Sender Sender { get; set; } = default!;

        /// <summary>
        /// 获取或设置收件人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Receiver")]
        [System.Text.Json.Serialization.JsonPropertyName("Receiver")]
        [System.Xml.Serialization.XmlElement("Receiver")]
        public Types.Receiver Receiver { get; set; } = default!;

        /// <summary>
        /// 获取或设置包裹信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("GoodDetail")]
        [System.Text.Json.Serialization.JsonPropertyName("GoodDetail")]
        [System.Xml.Serialization.XmlElement("GoodDetail", Type = typeof(Types.Cargo))]
        public Types.Cargo? Cargo { get; set; }

        /// <summary>
        /// 获取或设置保价信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Insured")]
        [System.Text.Json.Serialization.JsonPropertyName("Insured")]
        [System.Xml.Serialization.XmlElement("Insured", IsNullable = true)]
        public Types.Insurance? Insurance { get; set; }

        /// <summary>
        /// 获取或设置轨迹信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PathInfo")]
        [System.Text.Json.Serialization.JsonPropertyName("PathInfo")]
        [System.Xml.Serialization.XmlElement("PathInfo")]
        public Types.Path? Path { get; set; } = default!;

        /// <summary>
        /// 获取或设置运费（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Fee")]
        [System.Text.Json.Serialization.JsonPropertyName("Fee")]
        [System.Xml.Serialization.XmlElement("Fee", IsNullable = true)]
        public int? Fee { get; set; }

        /// <summary>
        /// 获取或设置原价（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OriginalFee")]
        [System.Text.Json.Serialization.JsonPropertyName("OriginalFee")]
        [System.Xml.Serialization.XmlElement("OriginalFee", IsNullable = true)]
        public int? OriginalFee { get; set; }

        /// <summary>
        /// 获取或设置在线支付方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("OnlinePay")]
        [System.Text.Json.Serialization.JsonPropertyName("OnlinePay")]
        [System.Xml.Serialization.XmlElement("OnlinePay", IsNullable = true)]
        public int? OnlinePayType { get; set; }

        /// <summary>
        /// 获取或设置支付结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("PayResult")]
        [System.Text.Json.Serialization.JsonPropertyName("PayResult")]
        [System.Xml.Serialization.XmlElement("PayResult", IsNullable = true)]
        public int? PayResult { get; set; }

        public QuerySingleWaybillReply()
        {
            MessageType = "event";
            Event = "query_single_waybill";
        }
    }
}
