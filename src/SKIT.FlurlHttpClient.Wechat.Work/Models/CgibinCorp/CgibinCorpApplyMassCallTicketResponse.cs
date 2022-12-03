namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/corp/apply_mass_call_ticket 接口的响应。</para>
    /// </summary>
    public class CgibinCorpApplyMassCallTicketResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置大批量调用凭据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mass_call_ticket")]
        [System.Text.Json.Serialization.JsonPropertyName("mass_call_ticket")]
        public string MassCallTicket { get; set; } = default!;
    }
}
