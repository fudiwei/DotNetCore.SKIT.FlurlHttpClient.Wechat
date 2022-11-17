namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corpgroup/import_chain_contact 接口的响应。</para>
    /// </summary>
    public class CgibinCorpGroupImportChainContactResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置导入任务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jobid")]
        [System.Text.Json.Serialization.JsonPropertyName("jobid")]
        public string JobId { get; set; } = default!;
    }
}
