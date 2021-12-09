namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /marketing/membercard-open/activate-informations/{activate_ticket} 接口的响应。</para>
    /// </summary>
    public class GetMarketingMemberCardOpenActivateInformationResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class UserInformation : GetMarketingMemberCardOpenCardCodeByCardIdAndCodeResponse.Types.UserInformation
            {
            }
        }

        /// <summary>
        /// 获取或设置用户的微信昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// 获取或设置用户的微信头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_image_url")]
        [System.Text.Json.Serialization.JsonPropertyName("head_image_url")]
        public string? HeadImageUrl { get; set; }

        /// <summary>
        /// 获取或设置用户开卡时填写的个人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_information")]
        [System.Text.Json.Serialization.JsonPropertyName("user_information")]
        public Types.UserInformation? UserInformation { get; set; }
    }
}
