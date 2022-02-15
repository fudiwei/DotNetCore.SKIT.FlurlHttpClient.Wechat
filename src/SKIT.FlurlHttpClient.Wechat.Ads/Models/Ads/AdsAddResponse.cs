namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /ads/add 接口的响应。</para>
    /// </summary>
    public class AdsAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置广告 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ad_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ad_id")]
                public long AdId { get; set; }
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
