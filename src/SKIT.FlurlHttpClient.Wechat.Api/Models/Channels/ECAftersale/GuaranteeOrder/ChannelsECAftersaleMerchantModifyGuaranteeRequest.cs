using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/merchantmodifyguarantee 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleMerchantModifyGuaranteeRequest : WechatApiRequest, IInferable<ChannelsECAftersaleMerchantModifyGuaranteeRequest, ChannelsECAftersaleMerchantModifyGuaranteeResponse>
    {
        /// <summary>
        /// 获取或设置保障单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id")]
        public long GuaranteeOrderId { get; set; }

        /// <summary>
        /// 获取或设置修改后的坏损比例。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bad_level")]
        [System.Text.Json.Serialization.JsonPropertyName("bad_level")]
        public int BadLevel { get; set; }

        /// <summary>
        /// 获取或设置商家备注。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_remark")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_remark")]
        public string? MerchantRemark { get; set; }
    }
}
