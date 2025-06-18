namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/school/set_teacher_view_mode 接口的请求。</para>
    /// </summary>
    public class CgibinSchoolSetTeacherViewModeRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置查看模式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("view_mode")]
        [System.Text.Json.Serialization.JsonPropertyName("view_mode")]
        public int ViewMode { get; set; }
    }
}
