namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/agent/get 接口的响应。</para>
    /// </summary>
    public class CgibinAgentGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class AllowedUser
            {
                public static class Types
                {
                    public class User
                    {
                        /// <summary>
                        /// 获取或设置成员账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("userid")]
                        [System.Text.Json.Serialization.JsonPropertyName("userid")]
                        public string UserId { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置成员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user")]
                [System.Text.Json.Serialization.JsonPropertyName("user")]
                public Types.User[] UserList { get; set; } = default!;
            }

            public class AllowedDepartment
            {
                /// <summary>
                /// 获取或设置部门 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partyid")]
                [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                public long[] DepartmentIdList { get; set; } = default!;
            }

            public class AllowedTag
            {
                /// <summary>
                /// 获取或设置标签 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tagid")]
                [System.Text.Json.Serialization.JsonPropertyName("tagid")]
                public int[] TagIdList { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置应用 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agentid")]
        [System.Text.Json.Serialization.JsonPropertyName("agentid")]
        public int AgentId { get; set; }

        /// <summary>
        /// 获取或设置应用名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; } = default!;

        /// <summary>
        /// 获取或设置应用方形头像 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("square_logo_url")]
        [System.Text.Json.Serialization.JsonPropertyName("square_logo_url")]
        public string SquareLogoUrl { get; set; } = default!;

        /// <summary>
        /// 获取或设置应用详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = default!;

        /// <summary>
        /// 获取或设置可见成员范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_userinfos")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_userinfos")]
        public Types.AllowedUser AllowedUser { get; set; } = default!;

        /// <summary>
        /// 获取或设置可见部门范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_partys")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_partys")]
        public Types.AllowedDepartment AllowedDepartment { get; set; } = default!;

        /// <summary>
        /// 获取或设置可见标签范围信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allow_tags")]
        [System.Text.Json.Serialization.JsonPropertyName("allow_tags")]
        public Types.AllowedTag AllowedTag { get; set; } = default!;

        /// <summary>
        /// 获取或设置是否被停用。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("close")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("close")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsClosed { get; set; }

        /// <summary>
        /// 获取或设置是否上报用户地理位置。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("report_location_flag")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("report_location_flag")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsReportLocation { get; set; }

        /// <summary>
        /// 获取或设置是否上报用户进入事件。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isreportenter")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("isreportenter")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalBooleanConverter))]
        public bool IsReportEnter { get; set; }

        /// <summary>
        /// 获取或设置可信域名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_domain")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_domain")]
        public string? RedirectDomain { get; set; }

        /// <summary>
        /// 获取或设置应用主页。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("home_url")]
        [System.Text.Json.Serialization.JsonPropertyName("home_url")]
        public string? HomeUrl { get; set; }

        /// <summary>
        /// 获取或设置代开发发布状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customized_publish_status")]
        [System.Text.Json.Serialization.JsonPropertyName("customized_publish_status")]
        public int? CustomizedPublishStatus { get; set; }
    }
}
