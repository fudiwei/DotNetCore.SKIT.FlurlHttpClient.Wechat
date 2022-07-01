namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/business/update 接口的请求。</para>
    /// </summary>
    public class CgibinBusinessUpdateRequest : WechatApiRequest, IInferable<CgibinBusinessUpdateRequest, CgibinBusinessUpdateResponse>
    {
        /// <summary>
        /// 获取或设置商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_id")]
        [System.Text.Json.Serialization.JsonPropertyName("business_id")]
        public long BusinessId { get; set; }

        /// <summary>
        /// 获取或设置商户昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nickname")]
        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
        public string? Nickname { get; set; }

        /// <summary>
        /// 获取或设置商户头像 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icon_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("icon_media_id")]
        public string? IconMediaId { get; set; }
    }
}
