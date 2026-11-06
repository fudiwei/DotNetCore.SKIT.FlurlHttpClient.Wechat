namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/user/info/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipUserInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class User : ChannelsECVipUserListGetResponse.Types.__zz__User
            {
                public static class Types
                {
                    public class GradeInfo : ChannelsECVipUserListGetResponse.Types.User.Types.GradeInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置用户等级信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_grade_info")]
                [System.Text.Json.Serialization.JsonPropertyName("user_grade_info")]
                public Types.GradeInfo? GradeInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.User? User { get; set; }
    }
}
