namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/batch/get_by_user 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactBatchGetByUserResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class ExternalContactUser
            {
                public static class Types
                {
                    public class ExternalContact : CgibinExternalContactGetResponse.Types.__zz__ExternalContact
                    {
                        public static class Types
                        {
                            public class Subscriber : CgibinExternalContactGetResponse.Types.ExternalContact.Types.Subscriber
                            {
                            }

                            public class ExternalProfile : CgibinUserCreateRequest.Types.__zz__ExternalProfile
                            {
                                public static class Types
                                {
                                    public class Attribute : CgibinUserCreateRequest.Types.ExternalProfile.Types.__zz__Attribute
                                    {
                                        public static class Types
                                        {
                                            public class Text : CgibinUserCreateRequest.Types.ExternalProfile.Types.Attribute.Types.Text
                                            {
                                            }

                                            public class Web : CgibinUserCreateRequest.Types.ExternalProfile.Types.Attribute.Types.Web
                                            {
                                            }

                                            public class MiniProgram : CgibinUserCreateRequest.Types.ExternalProfile.Types.Attribute.Types.MiniProgram
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

                                        /// <summary>
                                        /// 获取或设置小程序属性值。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("miniprogram")]
                                        [System.Text.Json.Serialization.JsonPropertyName("miniprogram")]
                                        public Types.MiniProgram? MiniProgram { get; set; }
                                    }

                                    public class WechatChannels : CgibinUserCreateRequest.Types.ExternalProfile.Types.WechatChannels
                                    {
                                    }
                                }

                                /// <summary>
                                /// 获取或设置视频号信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("wechat_channels")]
                                [System.Text.Json.Serialization.JsonPropertyName("wechat_channels")]
                                public Types.WechatChannels? WechatChannels { get; set; }

                                /// <summary>
                                /// 获取或设置对外自定义字段列表。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("external_attr")]
                                [System.Text.Json.Serialization.JsonPropertyName("external_attr")]
                                public List<Types.Attribute>? AttributeList { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置学校为家长设置的信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("subscriber_info")]
                        [System.Text.Json.Serialization.JsonPropertyName("subscriber_info")]
                        public Types.Subscriber? Subscriber { get; set; }

                        /// <summary>
                        /// 获取或设置对外属性信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("external_profile")]
                        [System.Text.Json.Serialization.JsonPropertyName("external_profile")]
                        public Types.ExternalProfile? ExternalProfile { get; set; }
                    }

                    public class FollowUser : CgibinExternalContactGetResponse.Types.__zz__FollowUser
                    {
                        public static class Types
                        {
                            public class Tag : CgibinExternalContactGetResponse.Types.FollowUser.Types.Tag
                            {
                            }

                            public class WechatChannels : CgibinExternalContactGetResponse.Types.FollowUser.Types.WechatChannels
                            {
                            }
                        }

                        /// <summary>
                        /// 获取或设置该成员添加外部联系人所打企业标签列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("tags")]
                        [System.Text.Json.Serialization.JsonPropertyName("tags")]
                        public List<Types.Tag>? TagList { get; set; }

                        /// <summary>
                        /// 获取或设置视频号信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("wechat_channels")]
                        [System.Text.Json.Serialization.JsonPropertyName("wechat_channels")]
                        public Types.WechatChannels? WechatChannels { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置外部联系人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_contact")]
                [System.Text.Json.Serialization.JsonPropertyName("external_contact")]
                public Types.ExternalContact? ExternalContact { get; set; }

                /// <summary>
                /// 获取或设置添加了此外部联系人的企业成员信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("follow_info")]
                [System.Text.Json.Serialization.JsonPropertyName("follow_info")]
                public Types.FollowUser? FollowUser { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置外部联系人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("external_contact_list")]
        [System.Text.Json.Serialization.JsonPropertyName("external_contact_list")]
        public List<Types.ExternalContactUser>? ExternalContactList { get; set; }

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
