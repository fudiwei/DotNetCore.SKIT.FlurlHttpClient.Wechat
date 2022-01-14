namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/changeopenid 接口的响应。</para>
    /// </summary>
    public class CgibinChangeOpenIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                public string ErrorMessage { get; set; } = default!;

                /// <summary>
                /// 获取或设置原用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ori_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("ori_openid")]
                public string OriginalOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置新用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("new_openid")]
                public string? NewOpenId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置转换结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
