namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getrelation 接口的响应。</para>
    /// </summary>
    public class PromoterGetRelationResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Relation
            {
                /// <summary>
                /// 获取或设置推广员的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("promoter_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("promoter_openid")]
                public string PromoterOpenId { get; set; } = default!;

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
                /// 获取或设置触达用户的 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string UserOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置触达场景值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene")]
                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                public int Scene { get; set; }

                /// <summary>
                /// 获取或设置小程序页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置触达时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置分享素材的自定义参数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share_extra_info")]
                [System.Text.Json.Serialization.JsonPropertyName("share_extra_info")]
                public string? ShareExtraInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置触达效果数据列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relation_list")]
        [System.Text.Json.Serialization.JsonPropertyName("relation_list")]
        public Types.Relation[] RelationList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_cnt")]
        [System.Text.Json.Serialization.JsonPropertyName("total_cnt")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置下一页分页起始 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_id")]
        [System.Text.Json.Serialization.JsonPropertyName("start_id")]
        public string? NextStartId { get; set; }
    }
}
