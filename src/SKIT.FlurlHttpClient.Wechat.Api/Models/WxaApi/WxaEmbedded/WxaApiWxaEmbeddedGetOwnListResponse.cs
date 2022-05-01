namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/wxaembedded/get_own_list 接口的响应。</para>
    /// </summary>
    public class WxaApiWxaEmbeddedGetOwnListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class WxaEmbedded : WxaApiWxaEmbeddedGetListResponse.Types.WxaEmbedded
            {
            }
        }

        /// <summary>
        /// 获取或设置授权方式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("embedded_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("embedded_flag")]
        public int AuthFlag { get; set; }

        /// <summary>
        /// 获取或设置半屏小程序列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_embedded_list")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_embedded_list")]
        public Types.WxaEmbedded[] WxaEmbeddedList { get; set; } = default!;
    }
}
