namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/merchantnotes/update 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderMerchantNotesUpdateRequest : WechatApiRequest, IInferable<ChannelsECOrderMerchantNotesUpdateRequest, ChannelsECOrderMerchantNotesUpdateResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 获取或设置商家备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_notes")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_notes")]
        public string MerchantNotes { get; set; } = string.Empty;
    }
}
