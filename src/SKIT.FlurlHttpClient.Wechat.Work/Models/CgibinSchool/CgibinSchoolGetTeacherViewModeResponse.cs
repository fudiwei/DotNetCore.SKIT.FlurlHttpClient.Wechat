namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/school/get_teacher_view_mode 接口的响应。</para>
    /// </summary>
    public class CgibinSchoolGetTeacherViewModeResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置查看模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("view_mode")]
        public int ViewMode { get; set; }
    }
}
