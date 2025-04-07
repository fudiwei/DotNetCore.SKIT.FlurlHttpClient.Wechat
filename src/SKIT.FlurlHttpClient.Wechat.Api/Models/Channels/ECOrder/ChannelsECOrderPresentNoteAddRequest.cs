using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/presentnote/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderPresentNoteAddRequest : WechatApiRequest, IInferable<ChannelsECOrderPresentNoteAddRequest, ChannelsECOrderPresentNoteAddResponse>
    {
        /// <summary>
        /// 获取或设置礼物订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("present_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("present_order_id")]
        public string PresetOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置礼物订单备注信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notes")]
        [System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string Notes { get; set; } = string.Empty;
    }
}
