namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/privatenumber/getphone 接口的响应。</para>
    /// </summary>
    public class ChannelsECMerchantPrivateNumberGetPhoneResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置认证状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status")]
        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public int Status { get; set; }

        /// <summary>
        /// 获取或设置失败原因。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_reason")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_reason")]
        public string? FailReason { get; set; }
    }
}
