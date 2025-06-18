namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxaapi/wxaembedded/get_list 接口的响应。</para>
    /// </summary>
    public class WxaApiWxaEmbeddedGetListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class WxaEmbedded
            {
                /// <summary>
                /// 获取或设置小程序 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序昵称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置小程序头像 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("headimg")]
                [System.Text.Json.Serialization.JsonPropertyName("headimg")]
                public string HeadImageUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请理由。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("reason")]
                [System.Text.Json.Serialization.JsonPropertyName("reason")]
                public string Reason { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置添加时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置半屏小程序列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_embedded_list")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_embedded_list")]
        public Types.WxaEmbedded[] WxaEmbeddedList { get; set; } = default!;
    }
}
