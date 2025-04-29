namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/deauthorizecopyright 接口的响应。</para>
    /// </summary>
    public class WxaSecVodDeauthorizeCopyrightResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Result : WxaSecVodAuthorizeCopyrightResponse.Types.Result
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
