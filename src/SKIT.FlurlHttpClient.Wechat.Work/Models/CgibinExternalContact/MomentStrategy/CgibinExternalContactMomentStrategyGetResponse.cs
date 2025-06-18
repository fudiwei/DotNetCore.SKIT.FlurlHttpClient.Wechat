namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/moment_strategy/get 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactMomentStrategyGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Strategy
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
                        public bool EnableViewMomentList { get; set; }

                        /// <summary>
                        /// 获取或设置是否可以成员发表客户朋友圈。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("send_moment")]
                        [System.Text.Json.Serialization.JsonPropertyName("send_moment")]
                        public bool EnableSendMoment { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置规则组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy_id")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy_id")]
                public int StrategyId { get; set; }

                /// <summary>
                /// 获取或设置父规则组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("parent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("parent_id")]
                public int ParentStrategyId { get; set; }

                /// <summary>
                /// 获取或设置规则组名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("strategy_name")]
                [System.Text.Json.Serialization.JsonPropertyName("strategy_name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置管理员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admin_list")]
                [System.Text.Json.Serialization.JsonPropertyName("admin_list")]
                public string[] AdminUserIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置权限信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privilege")]
                [System.Text.Json.Serialization.JsonPropertyName("privilege")]
                public Types.Privilege Privilege { get; set; } = default!;

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置规则组信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("strategy")]
        [System.Text.Json.Serialization.JsonPropertyName("strategy")]
        public Types.Strategy Strategy { get; set; } = default!;
    }
}
