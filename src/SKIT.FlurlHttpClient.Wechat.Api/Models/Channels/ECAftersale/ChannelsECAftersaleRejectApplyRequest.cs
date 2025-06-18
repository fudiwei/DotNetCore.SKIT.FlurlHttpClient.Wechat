namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/rejectapply 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleRejectApplyRequest : WechatApiRequest, IInferable<ChannelsECAftersaleRejectApplyRequest, ChannelsECAftersaleRejectApplyResponse>
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public string AftersaleOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reject_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
        public string? RejectReason { get; set; }
    }
}
