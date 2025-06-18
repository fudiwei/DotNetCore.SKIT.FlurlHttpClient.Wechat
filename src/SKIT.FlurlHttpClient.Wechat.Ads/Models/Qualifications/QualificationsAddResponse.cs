namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /qualifications/add 接口的响应。</para>
    /// </summary>
    public class QualificationsAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置资质 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qualification_id")]
                [System.Text.Json.Serialization.JsonPropertyName("qualification_id")]
                public int QualificationId { get; set; }
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
