namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/user/batch_update_student 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolUserBatchUpdateStudentResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Result : CgibinSchoolUserBatchCreateStudentResponse.Types.Result
            {
            }
        }

        /// <summary>
        /// 获取或设置结果列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result_list")]
        [System.Text.Json.Serialization.JsonPropertyName("result_list")]
        public List<Types.Result>? ResultList { get; set; }
    }
}
