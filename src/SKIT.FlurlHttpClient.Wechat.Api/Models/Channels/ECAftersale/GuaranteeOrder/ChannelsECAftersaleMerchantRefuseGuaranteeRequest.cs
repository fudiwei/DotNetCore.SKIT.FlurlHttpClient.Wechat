using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/merchantrefuseguarantee 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleMerchantRefuseGuaranteeRequest : WechatApiRequest, IInferable<ChannelsECAftersaleMerchantRefuseGuaranteeRequest, ChannelsECAftersaleMerchantRefuseGuaranteeResponse>
    {
        /// <summary>
        /// 获取或设置保障单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id")]
        public long GuaranteeOrderId { get; set; }

        /// <summary>
        /// 获取或设置拒绝原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason")]
        [System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string Reason { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置拒绝凭证 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_list")]
        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
        public IList<string>? PictureMediaIdList { get; set; }
    }
}
