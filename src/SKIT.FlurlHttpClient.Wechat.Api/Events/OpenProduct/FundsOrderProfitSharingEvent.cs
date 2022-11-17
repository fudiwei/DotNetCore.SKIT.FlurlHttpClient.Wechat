namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.funds_order_profitsharing 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/wxafunds/callback/profitsharing_order.html </para>
    /// </summary>
    public class FundsOrderProfitSharingEvent : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置商户分账单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("profit_sharing_no")]
                [System.Text.Json.Serialization.JsonPropertyName("profit_sharing_no")]
                [System.Xml.Serialization.XmlElement("profit_sharing_no")]
                public string OutProfitSharingNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置分账金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("amount")]
                [System.Text.Json.Serialization.JsonPropertyName("amount")]
                [System.Xml.Serialization.XmlElement("amount")]
                public int Amount { get; set; }

                /// <summary>
                /// 获取或设置分账状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("result")]
                [System.Text.Json.Serialization.JsonPropertyName("result")]
                [System.Xml.Serialization.XmlElement("result")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置完成时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("finish_time")]
                [System.Text.Json.Serialization.JsonPropertyName("finish_time")]
                [System.Xml.Serialization.XmlElement("finish_time")]
                public string FinishTimeString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置订单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_info")]
        [System.Text.Json.Serialization.JsonPropertyName("order_info")]
        [System.Xml.Serialization.XmlElement("order_info")]
        public Types.Order Order { get; set; } = default!;
    }
}
