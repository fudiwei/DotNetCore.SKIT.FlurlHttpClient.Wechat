namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.funds_order_refund 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/wxafunds/callback/refunds_order.html </para>
    /// </summary>
    public class FundsOrderRefundEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Order
            {
                /// <summary>
                /// 获取或设置商户退款单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("refund_no")]
                [System.Text.Json.Serialization.JsonPropertyName("refund_no")]
                [System.Xml.Serialization.XmlElement("refund_no")]
                public string OutRefundNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Xml.Serialization.XmlElement("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置退款成功时间字符串（格式：yyyy-MM-dd HH:mm:ss）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("success_time")]
                [System.Text.Json.Serialization.JsonPropertyName("success_time")]
                [System.Xml.Serialization.XmlElement("success_time", IsNullable = true)]
                public string? SuccessTimeString { get; set; }
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
