namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/icp/apply_icp_filing 接口的响应。</para>
    /// </summary>
    public class WxaICPApplyICPFilingResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Hint
            {
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

                /// <summary>
                /// 获取或设置校验失败的字段。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_field")]
                [System.Text.Json.Serialization.JsonPropertyName("err_field")]
                public string ErrorField { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置错误提示。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hints")]
        [System.Text.Json.Serialization.JsonPropertyName("hints")]
        public Types.Hint[]? Hints { get; set; }
    }
}
