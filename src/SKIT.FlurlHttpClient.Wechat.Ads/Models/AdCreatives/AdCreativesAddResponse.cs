namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /adcreatives/add 接口的响应。</para>
    /// </summary>
    public class AdCreativesAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置广告创意 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("adcreative_id")]
                [System.Text.Json.Serialization.JsonPropertyName("adcreative_id")]
                public long AdCreativeId { get; set; }
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
