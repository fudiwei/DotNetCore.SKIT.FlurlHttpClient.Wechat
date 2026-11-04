namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/linkedcorp/user/get 接口的响应。</para>
    /// </summary>
    public class CgibinLinkedCorpUserGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class CorpUser : CgibinLinkedCorpUserListResponse.Types.__zz__CorpUser
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
        /// 获取或设置互联企业成员信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("user_info")]
        public Types.CorpUser? CorpUser { get; set; }
    }
}
