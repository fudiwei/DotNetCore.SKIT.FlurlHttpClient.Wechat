namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [GET] /custom_audiences/get 接口的请求。</para>
    /// </summary>
    public class CustomAudiencesGetRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置自定义人群 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? CustomAudienceId { get; set; }

        /// <summary>
        /// 获取或设置页大小。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? PageSize { get; set; }

        /// <summary>
        /// 获取或设置页码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? Page { get; set; }
    }
}
