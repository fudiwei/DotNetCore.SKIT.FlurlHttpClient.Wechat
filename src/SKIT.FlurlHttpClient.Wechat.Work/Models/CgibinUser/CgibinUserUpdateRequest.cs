using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/user/update 接口的请求。</para>
    /// </summary>
    public class CgibinUserUpdateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class ExtendedAttribute : CgibinUserCreateRequest.Types.ExtendedAttribute
            {
            }

            public class ExternalProfile : CgibinUserCreateRequest.Types.ExternalProfile
            {
            }
        }

        /// <summary>
        /// 获取或设置成员账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置成员名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

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
        public int? Gender { get; set; }

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
        public IList<int>? DepartmentIdList { get; set; }

        /// <summary>
        /// 获取或设置部门次序列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order")]
        [System.Text.Json.Serialization.JsonPropertyName("order")]
        public IList<long>? DepartmentOrderList { get; set; }

        /// <summary>
        /// 获取或设置部门领导状态列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_leader_in_dept")]
        [System.Text.Json.Serialization.JsonPropertyName("is_leader_in_dept")]
        public IList<int>? DepartmentLeaderStatusList { get; set; }

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
        public IList<string>? DirectLeaderUserIdList { get; set; }

        /// <summary>
        /// 获取或设置头像 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("avatar_mediaid")]
        [System.Text.Json.Serialization.JsonPropertyName("avatar_mediaid")]
        public string? AvatarMediaId { get; set; }

        /// <summary>
        /// 获取或设置是否启用成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enable")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("enable")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 获取或设置是否邀请成员。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("to_invite")]
        [System.Text.Json.Serialization.JsonPropertyName("to_invite")]
        public bool? RequireInvite { get; set; }

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
