namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/contact/id_translate 接口的响应。</para>
    /// </summary>
    public class CgibinServiceContactIdTranslateResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置异步任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;
    }
}
