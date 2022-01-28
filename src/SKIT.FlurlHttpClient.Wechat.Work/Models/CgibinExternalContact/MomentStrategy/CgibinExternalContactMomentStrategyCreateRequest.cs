using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/moment_strategy/create 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactMomentStrategyCreateRequest : WechatWorkRequest
    {
        public static class Types
        {
            public class Privilege
            {
                /// <summary>
                /// 获取或设置是否可以查看成员的全部客户朋友圈发表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("view_moment_list")]
                [System.Text.Json.Serialization.JsonPropertyName("view_moment_list")]
                public bool? EnableViewMomentList { get; set; }

                /// <summary>
                /// 获取或设置是否可以发表客户朋友圈。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("send_moment")]
                [System.Text.Json.Serialization.JsonPropertyName("send_moment")]
                public bool? EnableSendMoment { get; set; }
            }

            public class Range
            {
                /// <summary>
                /// 获取或设置节点类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("type")]
                [System.Text.Json.Serialization.JsonPropertyName("type")]
                public int Type { get; set; }

                /// <summary>
                /// 获取或设置管理范围内配置的成员 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("userid")]
                [System.Text.Json.Serialization.JsonPropertyName("userid")]
                public string? UserId { get; set; }

                /// <summary>
                /// 获取或设置管理范围内配置的部门 UserId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("partyid")]
                [System.Text.Json.Serialization.JsonPropertyName("partyid")]
                public long? DepartmentId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置父规则组 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("parent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public int? ParentStrategyId { get; set; }

        /// <summary>
        /// 获取或设置规则组名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy_name")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy_name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置管理员 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("admin_list")]
        [System.Text.Json.Serialization.JsonPropertyName("admin_list")]
        public IList<string> AdminUserIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置权限信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privilege")]
        [System.Text.Json.Serialization.JsonPropertyName("privilege")]
        public Types.Privilege Privilege { get; set; } = new Types.Privilege();

        /// <summary>
        /// 获取或设置规则组范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range")]
        [System.Text.Json.Serialization.JsonPropertyName("range")]
        public IList<Types.Range> RangeList { get; set; } = new List<Types.Range>();
    }
}
