namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/reason/getbyorder 接口的响应。</para>
    /// </summary>
    public class ChannelsECAftersaleReasonGetByOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Reason : ChannelsECAftersaleReasonGetResponse.Types.Reason
            {
            }
        }

        /// <summary>
        /// 获取或设置“未发货、仅退款”可选售后原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_not_ship_reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_not_ship_reason_list")]
        public List<Types.Reason>? RefundNotShipReasonList { get; set; }

        /// <summary>
        /// 获取或设置“已发货、仅退款”可选售后原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_not_receive_reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_not_receive_reason_list")]
        public List<Types.Reason>? RefundNotReceiveReasonList { get; set; }

        /// <summary>
        /// 获取或设置“已收到货、仅退款”可选售后原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_receive_reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_receive_reason_list")]
        public List<Types.Reason>? RefundReceiveReasonList { get; set; }

        /// <summary>
        /// 获取或设置“已收到货、退货退款”可选售后原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_return_reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_return_reason_list")]
        public List<Types.Reason>? RefundReturnReasonList { get; set; }

        /// <summary>
        /// 获取或设置“换货”可选售后原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exchange_reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("exchange_reason_list")]
        public List<Types.Reason>? ExchangeReasonList { get; set; }

        /// <summary>
        /// 获取或设置“补寄”可选售后原因列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reship_reason_list")]
        [System.Text.Json.Serialization.JsonPropertyName("reship_reason_list")]
        public List<Types.Reason>? ReshipReasonList { get; set; }
    }
}
