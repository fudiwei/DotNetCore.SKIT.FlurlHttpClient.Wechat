namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /images/add 接口的响应。</para>
    /// </summary>
    public class ImagesAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data : ImagesGetResponse.Types.Data.Types.Image
            {
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
