namespace SKIT.FlurlHttpClient.Wechat.TenpayV2.Models
{
    /// <summary>
    /// <para>表示 [POST] /secapi/mch/uploadmedia 接口的响应。</para>
    /// </summary>
    public class UploadMerchantMediaResponse : WechatTenpaySignableResponse
    {
        /// <summary>
        /// <i>（请忽略此字段）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? MerchantId { get; set; }

        /// <summary>
        /// <i>（请忽略此字段）</i>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public override string? AppId { get; set; }

        /// <summary>
        /// 获取或设置媒体标识 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = default!;
    }
}
