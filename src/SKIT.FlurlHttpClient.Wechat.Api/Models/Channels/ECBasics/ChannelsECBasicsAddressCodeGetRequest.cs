namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/addresscode/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsAddressCodeGetRequest : WechatApiRequest, IInferable<ChannelsECBasicsAddressCodeGetRequest, ChannelsECBasicsAddressCodeGetResponse>
    {
        /// <summary>
        /// 获取或设置地址行政编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("addr_code")]
        [System.Text.Json.Serialization.JsonPropertyName("addr_code")]
        public int? AddressCode { get; set; }
    }
}
