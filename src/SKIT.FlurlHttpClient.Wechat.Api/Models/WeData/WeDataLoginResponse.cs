namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wedata/wedata_login 接口的响应。</para>
    /// </summary>
    public class WeDataLoginResponse : WechatApiResponse
    {
        public static class Types
        {
            public class BaseResponse
            {
                /// <summary>
                /// 获取或设置错误码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ret")]
                [System.Text.Json.Serialization.JsonPropertyName("ret")]
                public int ErrorCode { get; set; }

                /// <summary>
                /// 获取或设置错误信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("err_msg")]
                [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
                public string ErrorMessage { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置基本响应信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base_resp")]
        [System.Text.Json.Serialization.JsonPropertyName("base_resp")]
        public Types.BaseResponse BaseResponse { get; set; } = default!;

        /// <summary>
        /// 获取或设置 We 分析登录链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("redirect_url")]
        [System.Text.Json.Serialization.JsonPropertyName("redirect_url")]
        public string? RedirectUrl { get; set; }

        /// <summary>
        /// 获取或设置过期时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_at")]
        [System.Text.Json.Serialization.JsonPropertyName("expire_at")]
        public long? ExpireTimestamp { get; set; }

        public override bool IsSuccessful()
        {
            return base.IsSuccessful() && BaseResponse is not null && BaseResponse.ErrorCode == 0;
        }
    }
}
