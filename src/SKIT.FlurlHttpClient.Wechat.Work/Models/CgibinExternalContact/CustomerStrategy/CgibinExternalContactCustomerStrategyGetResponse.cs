namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_strategy/get 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerStrategyGetResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Strategy
            {
                public static class Types
                {
                    public class Privilege : CgibinExternalContactCustomerStrategyCreateRequest.Types.Privilege
                    {
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
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置管理员 UserId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("admin_list")]
                [System.Text.Json.Serialization.JsonPropertyName("admin_list")]
                public List<string>? AdminUserIdList { get; set; }

                /// <summary>
                /// 获取或设置权限信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("privilege")]
                [System.Text.Json.Serialization.JsonPropertyName("privilege")]
                public Types.Privilege? Privilege { get; set; }

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
        public Types.Strategy? Strategy { get; set; }
    }
}
