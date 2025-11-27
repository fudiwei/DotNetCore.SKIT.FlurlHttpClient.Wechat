namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/merchant/privatenumber/sendverifycode 接口的请求。</para>
    /// </summary>
    public class ChannelsECMerchantPrivateNumberSendVerifyCodeRequest : WechatApiRequest, IInferable<ChannelsECMerchantPrivateNumberSendVerifyCodeRequest, ChannelsECMerchantPrivateNumberSendVerifyCodeResponse>
    {
        /// <summary>
        /// 获取或设置待认证的手机号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("house_number")]
        [System.Text.Json.Serialization.JsonPropertyName("house_number")]
        public string MobileNumber { get; set; } = string.Empty;
    }
}
