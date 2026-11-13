namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/querybookauthv2 接口的响应。</para>
    /// </summary>
    public class WxaBookQueryBookAuthV2Response : WechatApiResponse
    {
        public static class Types
        {
            public class Result : WxaBookQueryBookAuthResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid_results")]
        [System.Text.Json.Serialization.JsonPropertyName("appid_results")]
        public List<Types.Result>? ResultList { get; set; }

        /// <summary>
        /// 获取或设置下一页分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_cursor")]
        [System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }
    }
}
