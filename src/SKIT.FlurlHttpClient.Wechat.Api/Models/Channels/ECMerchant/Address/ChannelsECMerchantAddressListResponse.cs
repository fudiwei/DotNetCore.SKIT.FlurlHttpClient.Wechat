namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/address/list 接口的响应。</para>
    /// </summary>
    public class ChannelsECMerchantAddressListResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置地址 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id_list")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.TextualLongArrayConverter))]
        public long[] AddressIdList { get; set; } = default!;
    }
}
