namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant/media/upload 接口的响应。</para>
    /// </summary>
    public class UploadMerchantMediaImageResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置媒体文件标识 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = default!;
    }
}
