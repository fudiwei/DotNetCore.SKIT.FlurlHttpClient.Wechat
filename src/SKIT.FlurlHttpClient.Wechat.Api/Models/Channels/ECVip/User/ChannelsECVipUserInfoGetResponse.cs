namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/info/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipUserInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class VipInfo : ChannelsECVipUserListGetResponse.Types.VipInfo
            {
            }
        }

        /// <summary>
        /// 获取或设置会员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.VipInfo VipInfo { get; set; } = default!;
    }
}
