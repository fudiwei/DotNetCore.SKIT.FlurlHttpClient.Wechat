namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/getwxamplinkforshow 接口的响应。</para>
    /// </summary>
    public class WxaGetWxaMpLinkForShowResponse : WechatApiResponse
    {
        public static class Types
        {
            public class MediaPlatform
            {
                /// <summary>
                /// 获取或设置公众号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置公众号名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置公众号头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimg")]
                [System.Text.Json.Serialization.JsonPropertyName("headimg")]
                public string HeadImageUrl { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置公众号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biz_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("biz_info_list")]
        public Types.MediaPlatform[] MediaPlatformList { get; set; } = default!;

        /// <summary>
        /// 获取或设置公众号总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
