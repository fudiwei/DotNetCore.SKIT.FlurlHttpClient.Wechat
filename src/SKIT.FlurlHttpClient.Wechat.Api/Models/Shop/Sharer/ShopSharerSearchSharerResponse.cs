namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/sharer/search_sharer 接口的响应。</para>
    /// </summary>
    public class ShopSharerSearchSharerResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分享员昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string Nickname { get; set; } = default!;

        /// <summary>
        /// 获取或设置邀请时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invited_time")]
        [System.Text.Json.Serialization.JsonPropertyName("invited_time")]
        public long InviteTimestamp { get; set; }

        /// <summary>
        /// 获取或设置绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
        public int BindStatus { get; set; }

        /// <summary>
        /// 获取或设置绑定时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_time")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
        public long? BindTimestamp { get; set; }
    }
}
