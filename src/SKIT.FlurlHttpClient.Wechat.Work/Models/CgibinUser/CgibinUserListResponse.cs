namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/list 接口的响应。</para>
    /// </summary>
    public class CgibinUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class User : CgibinUserSimpleListResponse.Types.User
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
                                /// <summary>
                                /// 获取或设置对外展示视频号状态。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("status")]
                                [System.Text.Json.Serialization.JsonPropertyName("status")]
                                public int? Status { get; set; }
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
                /// 获取或设置成员英文名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("english_name")]
                [System.Text.Json.Serialization.JsonPropertyName("english_name")]
                public string? EnglishName { get; set; }

                /// <summary>
                /// 获取或设置成员别名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("alias")]
                [System.Text.Json.Serialization.JsonPropertyName("alias")]
                public string? Alias { get; set; }

                /// <summary>
                /// 获取或设置邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("email")]
                [System.Text.Json.Serialization.JsonPropertyName("email")]
                public string? Email { get; set; }

                /// <summary>
                /// 获取或设置企业邮箱。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("biz_mail")]
                [System.Text.Json.Serialization.JsonPropertyName("biz_mail")]
                public string? BusinessEmail { get; set; }

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
                /// 获取或设置性别。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gender")]
                [System.Text.Json.Serialization.JsonPropertyName("gender")]
                [System.Text.Json.Serialization.JsonConverter(typeof(SKIT.JsonConv.SystemTextJson.Converters.StringifiedNumberReadOnlyConverter))]
                public int Gender { get; set; }

                /// <summary>
                /// 获取或设置地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address")]
                [System.Text.Json.Serialization.JsonPropertyName("address")]
                public string? Address { get; set; }

                /// <summary>
                /// 获取或设置职务。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("position")]
                [System.Text.Json.Serialization.JsonPropertyName("position")]
                public string? Position { get; set; }

                /// <summary>
                /// 获取或设置部门次序列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public List<long>? DepartmentOrderList { get; set; }

                /// <summary>
                /// 获取或设置部门领导状态列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_leader_in_dept")]
                [System.Text.Json.Serialization.JsonPropertyName("is_leader_in_dept")]
                public List<int>? DepartmentLeaderStatusList { get; set; }

                /// <summary>
                /// 获取或设置主部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("main_department")]
                [System.Text.Json.Serialization.JsonPropertyName("main_department")]
                public long? MainDepartmentId { get; set; }

                /// <summary>
                /// 获取或设置直属上级成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("direct_leader")]
                [System.Text.Json.Serialization.JsonPropertyName("direct_leader")]
                public List<string>? DirectLeaderUserIdList { get; set; }

                /// <summary>
                /// 获取或设置头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("avatar")]
                public string? AvatarUrl { get; set; }

                /// <summary>
                /// 获取或设置头像缩略图 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("thumb_avatar")]
                [System.Text.Json.Serialization.JsonPropertyName("thumb_avatar")]
                public string? AvatarThumbnailUrl { get; set; }

                /// <summary>
                /// 获取或设置二维码 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_code")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
                public string? QrcodeUrl { get; set; }

                /// <summary>
                /// 获取或设置激活状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置自定义字段信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extattr")]
                [System.Text.Json.Serialization.JsonPropertyName("extattr")]
                public Types.ExtendedAttribute? ExtendedAttribute { get; set; }

                /// <summary>
                /// 获取或设置对外职务。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_position")]
                [System.Text.Json.Serialization.JsonPropertyName("external_position")]
                public string? ExternalPosition { get; set; }

                /// <summary>
                /// 获取或设置对外属性信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("external_profile")]
                [System.Text.Json.Serialization.JsonPropertyName("external_profile")]
                public Types.ExternalProfile? ExternalProfile { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置成员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userlist")]
        [System.Text.Json.Serialization.JsonPropertyName("userlist")]
        public List<Types.User>? UserList { get; set; }
    }
}
