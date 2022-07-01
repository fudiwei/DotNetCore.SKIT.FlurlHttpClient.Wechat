namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/message/custom/business/send 接口的请求。</para>
    /// </summary>
    public class CgibinMessageCustomBusinessSendRequest : CgibinMessageCustomSendRequest, IInferable<CgibinMessageCustomBusinessSendRequest, CgibinMessageCustomBusinessSendResponse>
    {
        /// <summary>
        /// 获取或设置客服子商户 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("businessid")]
        [System.Text.Json.Serialization.JsonPropertyName("businessid")]
        public long BusinessId { get; set; }
    }
}
