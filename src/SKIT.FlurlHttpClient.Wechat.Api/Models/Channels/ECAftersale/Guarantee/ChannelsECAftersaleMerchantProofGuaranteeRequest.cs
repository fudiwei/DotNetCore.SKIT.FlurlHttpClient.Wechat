using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/merchantproofguarantee 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleMerchantProofGuaranteeRequest : WechatApiRequest, IInferable<ChannelsECAftersaleMerchantProofGuaranteeRequest, ChannelsECAftersaleMerchantProofGuaranteeResponse>
    {
        /// <summary>
        /// 获取或设置保障单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id")]
        public long GuaranteeOrderId { get; set; }

        /// <summary>
        /// 获取或设置举证内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content")]
        [System.Text.Json.Serialization.JsonPropertyName("content")]
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置举证凭证 MediaId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pic_list")]
        [System.Text.Json.Serialization.JsonPropertyName("pic_list")]
        public IList<string>? PictureMediaIdList { get; set; }
    }
}
