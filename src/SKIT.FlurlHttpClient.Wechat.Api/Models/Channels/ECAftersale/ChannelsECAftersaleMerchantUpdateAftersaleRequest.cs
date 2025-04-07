using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/merchantupdateaftersale 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleMerchantUpdateAftersaleRequest : WechatApiRequest, IInferable<ChannelsECAftersaleMerchantUpdateAftersaleRequest, ChannelsECAftersaleMerchantUpdateAftersaleResponse>
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public string AftersaleOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置售后类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public int Type { get; set; }

        /// <summary>
        /// 获取或设置金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置协商原因类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("update_reason_type")]
        [System.Text.Json.Serialization.JsonPropertyName("update_reason_type")]
        public int UpdateReasonType { get; set; }

        /// <summary>
        /// 获取或设置协商类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_update_type")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_update_type")]
        public int MerchantUpdateType { get; set; }

        /// <summary>
        /// 获取或设置协商描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_update_desc")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_update_desc")]
        public string MerchantUpdateDescription { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置协商凭证 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("media_ids")]
        public IList<string>? CertificateMediaIdList { get; set; }
    }
}
