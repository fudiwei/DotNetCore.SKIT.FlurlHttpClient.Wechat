namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/service/corpid_to_opencorpid 接口的响应。</para>
    /// </summary>
    public class CgibinServiceCorpIdToOpenCorpIdResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置服务商主体下的密文 CorpId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_corpid")]
        [System.Text.Json.Serialization.JsonPropertyName("open_corpid")]
        public string OpenCorpId { get; set; } = default!;
    }
}
