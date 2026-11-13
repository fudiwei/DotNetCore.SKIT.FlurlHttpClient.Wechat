namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/eldermedical/previewhopsnotice 接口的请求。</para>
    /// </summary>
    public class IntpElderMedicalPreviewHospitalNoticeRequest : WechatApiRequest, IInferable<IntpElderMedicalPreviewHospitalNoticeRequest, IntpElderMedicalPreviewHospitalNoticeResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("app_id")]
        [System.Text.Json.Serialization.JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置公告类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_type")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_type")]
        public int NoticeType { get; set; }

        /// <summary>
        /// 获取或设置公告 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_id")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_id")]
        public int NoticeId { get; set; }

        /// <summary>
        /// 获取或设置可以预览公告的微信号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preview_username")]
        [System.Text.Json.Serialization.JsonPropertyName("preview_username")]
        public string? PreviewUsername { get; set; }

        /// <summary>
        /// 获取或设置操作类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operation")]
        [System.Text.Json.Serialization.JsonPropertyName("operation")]
        public int OperateType { get; set; }
    }
}
