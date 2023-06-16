namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/phonenumber/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsPhoneNumberGetResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置真实号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone")]
        [System.Text.Json.Serialization.JsonPropertyName("phone")]
        public string PhoneNumber { get; set; } = default!;
    }
}
