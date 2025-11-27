using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/order/realnumber/apply 接口的请求。</para>
    /// </summary>
    public class ChannelsECOrderRealNumberApplyRequest : WechatApiRequest, IInferable<ChannelsECOrderRealNumberApplyRequest, ChannelsECOrderRealNumberApplyResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string OrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_type")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_type")]
        public int ApplyType { get; set; }

        /// <summary>
        /// 获取或设置申请原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("apply_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("apply_reason")]
        public string ApplyReason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置申请原因图片 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_media_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("pic_media_ids")]
        public IList<string> PictureMediaIdList { get; set; } = new List<string>();
    }
}
