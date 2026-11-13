namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/eldermedical/sethopsnotice 接口的请求。</para>
    /// </summary>
    public class IntpElderMedicalSetHospitalNoticeRequest : WechatApiRequest, IInferable<IntpElderMedicalSetHospitalNoticeRequest, IntpElderMedicalSetHospitalNoticeResponse>
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
        public int? NoticeId { get; set; }

        /// <summary>
        /// 获取或设置公告内容。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_content")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_content")]
        public string? NoticeContent { get; set; }
    }
}
