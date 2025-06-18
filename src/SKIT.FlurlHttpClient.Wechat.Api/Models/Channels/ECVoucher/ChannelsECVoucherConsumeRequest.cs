using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/consume 接口的请求。</para>
    /// </summary>
    public class ChannelsECVoucherConsumeRequest : WechatApiRequest, IInferable<ChannelsECVoucherConsumeRequest, ChannelsECVoucherConsumeResponse>
    {
        /// <summary>
        /// 获取或设置商户核销单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_request_no")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_request_no")]
        public string ConsumeRequestNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置核销门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_store_name")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_store_name")]
        public string? ConsumeStoreName { get; set; }

        /// <summary>
        /// 获取或设置核销渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consume_channel")]
        [System.Text.Json.Serialization.JsonPropertyName("consume_channel")]
        public int? ConsumeChannel { get; set; }

        /// <summary>
        /// 获取或设置核销门店外部 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_store_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_store_id")]
        public string? OutStoreId { get; set; }

        /// <summary>
        /// 获取或设置加密的券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encrypted_codes")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_codes")]
        public IList<string>? EncryptedCodeList { get; set; }

        /// <summary>
        /// 获取或设置券码列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("codes")]
        [System.Text.Json.Serialization.JsonPropertyName("codes")]
        public IList<string>? CodeList { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long? SKUId { get; set; }
    }
}
