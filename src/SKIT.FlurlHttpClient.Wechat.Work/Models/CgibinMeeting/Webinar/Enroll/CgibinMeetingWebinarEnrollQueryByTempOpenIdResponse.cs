namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/webinar/enroll/query_by_tmp_openid 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingWebinarEnrollQueryByTempOpenIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result : CgibinMeetingEnrollQueryByTempOpenIdResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_id_list")]
        public List<Types.Result>? ResultList { get; set; }
    }
}
