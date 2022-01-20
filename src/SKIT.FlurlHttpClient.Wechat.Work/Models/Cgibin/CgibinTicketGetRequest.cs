namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/ticket/get 接口的请求。</para>
    /// </summary>
    public class CgibinTicketGetRequest : CgibinGetJsapiTicketRequest
    {
        /// <summary>
        /// 获取或设置票据类型。
        /// <para>默认值：agent_config</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Type { get; set; } = "agent_config";
    }
}
