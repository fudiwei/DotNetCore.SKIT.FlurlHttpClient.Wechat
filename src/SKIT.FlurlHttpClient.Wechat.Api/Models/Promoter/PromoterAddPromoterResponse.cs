namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/addpromoter 接口的响应。</para>
    /// </summary>
    public class PromoterAddPromoterResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
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
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errcode")]
                [System.Text.Json.Serialization.JsonPropertyName("errcode")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("errmsg")]
                [System.Text.Json.Serialization.JsonPropertyName("errmsg")]
                public string? ErrorMessage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_list")]
        public Types.Result[] ResultList { get; set; } = default!;

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
