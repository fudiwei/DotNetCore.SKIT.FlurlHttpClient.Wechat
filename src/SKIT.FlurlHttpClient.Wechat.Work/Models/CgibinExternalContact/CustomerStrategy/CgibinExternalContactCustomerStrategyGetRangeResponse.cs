namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/customer_strategy/get_range 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactCustomerStrategyGetRangeResponse : WechatWorkResponse
    {
        public static class Types
        {
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
        /// 获取或设置规则组范围列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("range")]
        [System.Text.Json.Serialization.JsonPropertyName("range")]
        public Types.Range[] RangeList { get; set; } = default!;

        /// <summary>
        /// 获取或设置翻页标记。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
