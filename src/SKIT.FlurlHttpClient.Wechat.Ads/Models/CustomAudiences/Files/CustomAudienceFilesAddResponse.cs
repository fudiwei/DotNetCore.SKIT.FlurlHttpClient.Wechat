namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /custom_audience_files/add 接口的响应。</para>
    /// </summary>
    public class CustomAudienceFilesAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置自定义人群数据文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_audience_file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_audience_file_id")]
                public int CustomAudienceFileId { get; set; }
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
