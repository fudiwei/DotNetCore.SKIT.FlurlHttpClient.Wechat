namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/voucher/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECVoucherGetRequest : WechatApiRequest, IInferable<ChannelsECVoucherGetRequest, ChannelsECVoucherGetResponse>
    {
        /// <summary>
        /// 获取或设置加密的券码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encrypted_code")]
        [System.Text.Json.Serialization.JsonPropertyName("encrypted_code")]
        public string? EncryptedCode { get; set; }

        /// <summary>
        /// 获取或设置券码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("code")]
        [System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// 获取或设置 SKU ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sku_id")]
        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
        public long? SKUId { get; set; }
    }
}
