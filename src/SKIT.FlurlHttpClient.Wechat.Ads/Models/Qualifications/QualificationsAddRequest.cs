namespace SKIT.FlurlHttpClient.Wechat.Ads.Models
{
    /// <summary>
    /// <para>表示 [POST] /qualifications/add 接口的请求。</para>
    /// </summary>
    public class QualificationsAddRequest : WechatAdsRequest
    {
        /// <summary>
        /// 获取或设置资质类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_type")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
        public string QualificationType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资质名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_name")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_name")]
        public string QualificationName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置资质证明文件图片 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_image_id")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_image_id")]
        public string QualificationImageId { get; set; } = string.Empty;
    }
}
