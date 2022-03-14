namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/sitecode/get_site_report_info 接口的请求。</para>
    /// </summary>
    public class CgibinReportSiteCodeGetSiteReportInfoRequest : WechatWorkRequest
    {
        /// <summary>
        /// 获取或设置场所码 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("siteid")]
        [System.Text.Json.Serialization.JsonPropertyName("siteid")]
        public string SiteCodeId { get; set; } = string.Empty;
    }
}
