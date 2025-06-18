namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/report/grid/update 接口的响应。</para>
    /// </summary>
    public class CgibinReportGridUpdateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置无效的 UserId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("invalid_userids")]
        [System.Text.Json.Serialization.JsonPropertyName("invalid_userids")]
        public string[]? InvalidUserIdList { get; set; }
    }
}
