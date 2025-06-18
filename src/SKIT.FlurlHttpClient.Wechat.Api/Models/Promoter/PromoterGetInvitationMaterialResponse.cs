namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /promoter/getinvitationmaterial 接口的响应。</para>
    /// </summary>
    public class PromoterGetInvitationMaterialResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置短链接。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag")]
        [System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? TagUrl { get; set; }

        /// <summary>
        /// 获取或设置经 Base64 编码的海报数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("poster")]
        [System.Text.Json.Serialization.JsonPropertyName("poster")]
        public string? EndcodingPosterData { get; set; }

        /// <summary>
        /// 获取或设置经 Base64 编码的二维码数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qrcode")]
        [System.Text.Json.Serialization.JsonPropertyName("qrcode")]
        public string? EncodingQrcodeData { get; set; }
    }
}
