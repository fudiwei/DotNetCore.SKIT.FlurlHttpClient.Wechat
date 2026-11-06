namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/membercard/activatetempinfo/get 接口的响应。</para>
    /// </summary>
    public class CardMemberCardActivateTempInfoGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MemberUser
            {
                public static class Types
                {
                    public class CustomField : CardMemberCardUserInfoGetResponse.Types.MemberUser.Types.CustomField
                    {
                    }
                }

                /// <summary>
                /// 获取或设置内置会员信息类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public List<Types.CustomField>? CommonFieldList { get; set; }

                /// <summary>
                /// 获取或设置自定义会员信息类目列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public List<Types.CustomField>? CustomFieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.MemberUser? MemberUser { get; set; }
    }
}
