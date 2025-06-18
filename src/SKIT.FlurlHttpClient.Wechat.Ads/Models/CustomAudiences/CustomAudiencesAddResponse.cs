namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /custom_audiences/add 接口的响应。</para>
    /// </summary>
    public class CustomAudiencesAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置自定义人群 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audience_id")]
                [System.Text.Json.Serialization.JsonPropertyName("audience_id")]
                public int CustomAudienceId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
