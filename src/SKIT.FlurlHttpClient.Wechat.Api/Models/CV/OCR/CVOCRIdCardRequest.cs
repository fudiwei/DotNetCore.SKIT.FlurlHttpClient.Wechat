namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/idcard 接口的请求。</para>
    /// </summary>
    public class CVOCRIdCardRequest : CVOCRCommonRequest
    {
        /// <summary>
        /// 获取或设置图片识别模式。
        /// <para>默认值：photo</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ImageMode { get; set; } = "photo";
    }
}
