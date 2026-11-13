namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/eldermedical/sethopsnotice 接口的响应。</para>
    /// </summary>
    public class IntpElderMedicalSetHospitalNoticeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置公告 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notice_id")]
        [System.Text.Json.Serialization.JsonPropertyName("notice_id")]
        public int NoticeId { get; set; }
    }
}
