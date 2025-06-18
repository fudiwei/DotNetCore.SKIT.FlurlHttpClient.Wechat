namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /estimation/get 接口的响应。</para>
    /// </summary>
    public class EstimationGetResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置预估覆盖人数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("approximate_count")]
                [System.Text.Json.Serialization.JsonPropertyName("approximate_count")]
                public int ApproximateCount { get; set; }

                /// <summary>
                /// 获取或设置预估曝光量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("impression")]
                [System.Text.Json.Serialization.JsonPropertyName("impression")]
                public int ImpressCount { get; set; }
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
