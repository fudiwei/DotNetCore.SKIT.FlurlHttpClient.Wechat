namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/enroll/import 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarEnrollImportResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Enroll : CgibinMeetingEnrollImportResponse.Types.Enroll
            {
            }
        }

        /// <summary>
        /// 获取或设置成功导入的报名信息条数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_count")]
        [System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int TotalCount { get; set; }

        /// <summary>
        /// 获取或设置报名列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_list")]
        public List<Types.Enroll>? EnrollList { get; set; }
    }
}
