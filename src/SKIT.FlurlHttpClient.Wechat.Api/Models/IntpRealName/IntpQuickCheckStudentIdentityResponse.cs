namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /intp/quickcheckstudentidentity 接口的响应。</para>
    /// </summary>
    public class IntpQuickCheckStudentIdentityResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置绑定状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bind_status")]
        [System.Text.Json.Serialization.JsonPropertyName("bind_status")]
        public int BindStatus { get; set; }

        /// <summary>
        /// 获取或设置是否是学生。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_student")]
        [System.Text.Json.Serialization.JsonPropertyName("is_student")]
        public bool IsStudent { get; set; }
    }
}
