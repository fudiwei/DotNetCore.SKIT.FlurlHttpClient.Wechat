namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /adgroups/add 接口的响应。</para>
    /// </summary>
    public class AdGroupsAddResponse : WechatAdsResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置广告组 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("adgroup_id")]
                [System.Text.Json.Serialization.JsonPropertyName("adgroup_id")]
                public long AdGroupId { get; set; }
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
