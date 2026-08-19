using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/handlefastexchangereceipt 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleHandleFastExchangeReceiptRequest : WechatApiRequest, IInferable<ChannelsECAftersaleHandleFastExchangeReceiptRequest, ChannelsECAftersaleHandleFastExchangeReceiptResponse>
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public string AftersaleOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("act")]
        [System.Text.Json.Serialization.JsonPropertyName("act")]
        public int ActionType { get; set; }

        /// <summary>
        /// 获取或设置拒绝原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason_type")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason_type")]
        public int? RejectReasonType { get; set; }

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }

        /// <summary>
        /// 获取或设置补充描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_text")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_text")]
        public string? MerchantText { get; set; }

        /// <summary>
        /// 获取或设置举证材料 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_confirm_exchange")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_confirm_exchange")]
        public IList<string>? MediaIdList { get; set; }
    }
}
