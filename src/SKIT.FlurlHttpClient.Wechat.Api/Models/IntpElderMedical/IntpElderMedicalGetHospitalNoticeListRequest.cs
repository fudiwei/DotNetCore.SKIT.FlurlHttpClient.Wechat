namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/eldermedical/gethospnoticelist 接口的请求。</para>
    /// </summary>
    public class IntpElderMedicalGetHospitalNoticeListRequest : WechatApiRequest, IInferable<IntpElderMedicalGetHospitalNoticeListRequest, IntpElderMedicalGetHospitalNoticeListResponse>
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
    }
}
