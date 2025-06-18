namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/memberauth?action=get_experiencer 接口的响应。</para>
    /// </summary>
    public class WxaMemberAuthGetExperiencerResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Member
            {
                /// <summary>
                /// 获取或设置人员对应的唯一字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userstr")]
                [System.Text.Json.Serialization.JsonPropertyName("userstr")]
                public string UserString { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置人员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("members")]
        [System.Text.Json.Serialization.JsonPropertyName("members")]
        public Types.Member[] MemberList { get; set; } = default!;
    }
}
