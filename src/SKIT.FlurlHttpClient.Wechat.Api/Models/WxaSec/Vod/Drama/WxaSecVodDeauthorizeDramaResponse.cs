namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/deauthorizedrama 接口的响应。</para>
    /// </summary>
    public class WxaSecVodDeauthorizeDramaResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result : WxaSecVodAuthorizeDramaResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
