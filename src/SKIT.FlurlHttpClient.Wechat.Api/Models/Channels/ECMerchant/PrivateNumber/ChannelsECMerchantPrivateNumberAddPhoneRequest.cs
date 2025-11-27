namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/privatenumber/addphone 接口的请求。</para>
    /// </summary>
    public class ChannelsECMerchantPrivateNumberAddPhoneRequest : WechatApiRequest, IInferable<ChannelsECMerchantPrivateNumberAddPhoneRequest, ChannelsECMerchantPrivateNumberAddPhoneResponse>
    {
        /// <summary>
        /// 获取或设置待认证的手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("house_number")]
        [System.Text.Json.Serialization.JsonPropertyName("house_number")]
        public string MobileNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置短信验证码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verify_code")]
        [System.Text.Json.Serialization.JsonPropertyName("verify_code")]
        public string VerifyCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置小店成员的微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxusername")]
        [System.Text.Json.Serialization.JsonPropertyName("wxusername")]
        public string? Username { get; set; }
    }
}
