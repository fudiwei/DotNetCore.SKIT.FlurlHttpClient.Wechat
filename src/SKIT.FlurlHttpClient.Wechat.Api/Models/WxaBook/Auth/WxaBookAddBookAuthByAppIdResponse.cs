namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/book/addbookauthbyappid 接口的响应。</para>
    /// </summary>
    public class WxaBookAddBookAuthByAppIdResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result : WxaBookAddBookAuthResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("results")]
        [System.Text.Json.Serialization.JsonPropertyName("results")]
        public List<Types.Result>? ResultList { get; set; }
    }
}
