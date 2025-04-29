namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/getcopyrightauthorizedlist 接口的响应。</para>
    /// </summary>
    public class WxaSecVodGetCopyrightAuthorizedListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class DramaCopyright : WxaSecVodGetCopyrightAuthorizationListResponse.Types.DramaCopyright
            {
            }
        }

        /// <summary>
        /// 获取或设置授权列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.DramaCopyright[] DramaCopyrightList { get; set; } = default!;

        /// <summary>
        /// 获取或设置记录总数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }
    }
}
