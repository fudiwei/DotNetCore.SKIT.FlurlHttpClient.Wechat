namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getsharematerial 接口的请求。</para>
    /// </summary>
    public class PromoterGetShareMaterialRequest : PublisherStatSettlementRequest, IInferable<PromoterGetShareMaterialRequest, PromoterGetShareMaterialResponse>
    {
        /// <summary>
        /// 获取或设置小程序页面名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("title")]
        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string? PageTitle { get; set; }

        /// <summary>
        /// 获取或设置小程序页面路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("path")]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public string PagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置推广员的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置自定义参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("extra_info")]
        [System.Text.Json.Serialization.JsonPropertyName("extra_info")]
        public string? ExtraInfo { get; set; }

        /// <summary>
        /// 获取或设置分享类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("share_type")]
        [System.Text.Json.Serialization.JsonPropertyName("share_type")]
        public int? ShareType { get; set; }

        /// <summary>
        /// 获取或设置小程序版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("env_version")]
        [System.Text.Json.Serialization.JsonPropertyName("env_version")]
        public string? EnvironmentVersion { get; set; }
    }
}
