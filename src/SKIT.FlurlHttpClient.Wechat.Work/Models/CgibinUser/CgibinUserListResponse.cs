namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/user/list 接口的响应。</para>
    /// </summary>
    public class CgibinUserListResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class User
            {
                public static class Types
                {
                    public class ExtendedAttribute : CgibinUserGetResponse.Types.ExtendedAttribute
                    {
                    }

                    public class ExternalProfile : CgibinUserGetResponse.Types.ExternalProfile
                    {
                    }
                }

                /// <summary>
                /// 获取或设置成员账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string UserId { get; set; } = default!;

                /// <summary>
                /// 获取或设置第三方成员唯一标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("open_userid")]
                [System.Text.Json.Serialization.JsonPropertyName("open_userid")]
                public string? OpenUserId { get; set; }

                /// <summary>
                /// 获取或设置成员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

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
                /// 获取或设置部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("department")]
                [System.Text.Json.Serialization.JsonPropertyName("department")]
                public int[] DepartmentIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置部门次序列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order")]
                [System.Text.Json.Serialization.JsonPropertyName("order")]
                public long[] DepartmentOrderList { get; set; } = default!;

                /// <summary>
                /// 获取或设置部门领导状态列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_leader_in_dept")]
                [System.Text.Json.Serialization.JsonPropertyName("is_leader_in_dept")]
                public int[]? DepartmentLeaderStatusList { get; set; }

                /// <summary>
                /// 获取或设置主部门 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("main_department")]
                [System.Text.Json.Serialization.JsonPropertyName("main_department")]
                public int? MainDepartmentId { get; set; }

                /// <summary>
                /// 获取或设置直属上级成员账号列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("direct_leader")]
                [System.Text.Json.Serialization.JsonPropertyName("direct_leader")]
                public string[]? DirectLeaderUserIdList { get; set; }

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
        public Types.User[] UserList { get; set; } = default!;
    }
}
