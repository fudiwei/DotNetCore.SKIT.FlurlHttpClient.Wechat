namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/user/list 接口的响应。</para>
    /// </summary>
    public class CgibinLinkedCorpUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public abstract class __zz__CorpUser : CgibinLinkedCorpUserSimpleListResponse.Types.CorpUser
            {
                /// <summary>
                /// 获取或设置手机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                public string? MobileNumber { get; set; }

                /// <summary>
                /// 获取或设置座机号码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("telephone")]
                [System.Text.Json.Serialization.JsonPropertyName("telephone")]
                public string? TeleNumber { get; set; }

                /// <summary>
                /// 获取或设置邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }

                /// <summary>
                /// 获取或设置职务。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("position")]
                [System.Text.Json.Serialization.JsonPropertyName("position")]
                public string? Position { get; set; }
            }

            public class CorpUser : __zz__CorpUser
            {
                public static class Types
                {
                    public class ExtendedAttribute
                    {
                        public static class Types
                        {
                            public class Attribute : CgibinUserCreateRequest.Types.ExtendedAttribute.Types.__zz__Attribute
                            {
                                public static class Types
                                {
                                    public class Text : CgibinUserCreateRequest.Types.ExtendedAttribute.Types.Attribute.Types.Text
                                    {
                                    }

                                    public class Web : CgibinUserCreateRequest.Types.ExtendedAttribute.Types.Attribute.Types.Web
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置文本属性值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("text")]
                                [System.Text.Json.Serialization.JsonPropertyName("text")]
                                public Types.Text? Text { get; set; }

                                /// <summary>
                                /// 获取或设置网页属性值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("web")]
                                [System.Text.Json.Serialization.JsonPropertyName("web")]
                                public Types.Web? Web { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置自定义字段列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("attrs")]
                        [System.Text.Json.Serialization.JsonPropertyName("attrs")]
                        public List<Types.Attribute>? AttributeList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置自定义字段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extattr")]
                [System.Text.Json.Serialization.JsonPropertyName("extattr")]
                public Types.ExtendedAttribute? ExtendedAttribute { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置互联企业成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userlist")]
        [System.Text.Json.Serialization.JsonPropertyName("userlist")]
        public List<Types.CorpUser>? CorpUserList { get; set; }
    }
}
