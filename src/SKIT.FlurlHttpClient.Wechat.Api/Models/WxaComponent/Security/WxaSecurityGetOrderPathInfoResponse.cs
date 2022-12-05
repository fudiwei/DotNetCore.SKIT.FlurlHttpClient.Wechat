namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/security/getorderpathinfo 接口的响应。</para>
    /// </summary>
    public class WxaSecurityGetOrderPathInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Page
            {
                /// <summary>
                /// 获取或设置页面路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string PagePath { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请材料图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("img_list")]
                [System.Text.Json.Serialization.JsonPropertyName("img_list")]
                public string[]? ImageUrlList { get; set; }

                /// <summary>
                /// 获取或设置申请材料视频 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video")]
                [System.Text.Json.Serialization.JsonPropertyName("video")]
                public string? VideoUrl { get; set; }

                /// <summary>
                /// 获取或设置测试账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("test_account")]
                [System.Text.Json.Serialization.JsonPropertyName("test_account")]
                public string? TestAccount { get; set; }

                /// <summary>
                /// 获取或设置测试账号密码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("test_pwd")]
                [System.Text.Json.Serialization.JsonPropertyName("test_pwd")]
                public string? TestPassword { get; set; }

                /// <summary>
                /// 获取或设置测试备注。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("test_remark")]
                [System.Text.Json.Serialization.JsonPropertyName("test_remark")]
                public string? TestRemark { get; set; }

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置申请时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_time")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_time")]
                public long ApplyTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置订单页信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("msg")]
        [System.Text.Json.Serialization.JsonPropertyName("msg")]
        public Types.Page Page { get; set; } = default!;
    }
}
