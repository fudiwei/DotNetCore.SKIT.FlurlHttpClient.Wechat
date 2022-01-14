namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/activatetempinfo/get 接口的响应。</para>
    /// </summary>
    public class CardMemberCardActivateTempInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MemberUser : CardCodeGetResponse.Types.MemberUser
            {
            }
        }

        /// <summary>
        /// 获取或设置会员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.MemberUser MemberUser { get; set; } = default!;
    }
}
