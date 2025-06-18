namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/meeting/enroll/query_by_tmp_openid 接口的响应。</para>
    /// </summary>
    public class CgibinMeetingEnrollQueryByTempOpenIdResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result
            {
                /// <summary>
                /// 获取或设置会议的成员临时 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("tmp_openid")]
                [System.Text.Json.Serialization.JsonPropertyName("tmp_openid")]
                public string TempOpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置报名 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("enroll_id")]
                [System.Text.Json.Serialization.JsonPropertyName("enroll_id")]
                public string EnrollId { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enroll_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("enroll_id_list")]
        public Types.Result[] ResultList { get; set; } = default!;
    }
}
