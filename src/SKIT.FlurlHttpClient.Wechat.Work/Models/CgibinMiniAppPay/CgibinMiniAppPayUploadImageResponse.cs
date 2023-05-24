namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/miniapppay/upload_image 接口的响应。</para>
    /// </summary>
    public class CgibinMiniAppPayUploadImageResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置图片 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_wx_pay_media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("open_wx_pay_media_id")]
        public string MediaId { get; set; } = default!;
    }
}
