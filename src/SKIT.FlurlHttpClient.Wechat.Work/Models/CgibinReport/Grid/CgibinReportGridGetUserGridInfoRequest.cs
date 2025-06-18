namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/get_user_grid_info 接口的请求。</para>
    /// </summary>
    public class CgibinReportGridGetUserGridInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置指定用户 UserId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userid")]
        [System.Text.Json.Serialization.JsonPropertyName("userid")]
        public string UserId { get; set; } = string.Empty;
    }
}
