namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/enroll/import 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarEnrollImportResponse : CgibinMeetingEnrollImportResponse
    {
        public static new class Types
        {
            public class Enroll : CgibinMeetingEnrollImportResponse.Types.Enroll
            {
            }
        }

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_list")]
        public new Types.Enroll[] EnrollList { get; set; } = default!;
    }
}
