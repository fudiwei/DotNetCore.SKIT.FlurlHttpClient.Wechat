namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getpromoter 接口的响应。</para>
    /// </summary>
    public class PromoterGetPromoterResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Promoter
            {
                /// <summary>
                /// 获取或设置推广员 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public string PromoterId { get; set; } = default!;

                /// <summary>
                /// 获取或设置推广员的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置角色 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role_id")]
                [System.Text.Json.Serialization.JsonPropertyName("role_id")]
                public int RoleId { get; set; }

                /// <summary>
                /// 获取或设置门店 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("retail_id")]
                [System.Text.Json.Serialization.JsonPropertyName("retail_id")]
                public string? RetailId { get; set; }

                /// <summary>
                /// 获取或设置推广员参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("extra_info")]
                [System.Text.Json.Serialization.JsonPropertyName("extra_info")]
                public string? ExtraInfo { get; set; }

                /// <summary>
                /// 获取或设置推广员名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string? Name { get; set; }

                /// <summary>
                /// 获取或设置推广员手机号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string? PhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置推广员授权状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auth_status")]
                [System.Text.Json.Serialization.JsonPropertyName("auth_status")]
                public int AuthStatus { get; set; }

                /// <summary>
                /// 获取或设置商家声明状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("decl_status")]
                [System.Text.Json.Serialization.JsonPropertyName("decl_status")]
                public int DeclareStatus { get; set; }

                /// <summary>
                /// 获取或设置推广员授权状态变更时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置推广员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promoter_list")]
        [System.Text.Json.Serialization.JsonPropertyName("promoter_list")]
        public Types.Promoter[] PromoterList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_cnt")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置失败的数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_cnt")]
        public int FailedCount { get; set; }
    }
}
