namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getsnticket 接口的请求。</para>
    /// </summary>
    public class WxaGetSnTicketRequest : WechatApiRequest, IMapResponse<WxaGetSnTicketRequest, WxaGetSnTicketResponse>
    {
        /// <summary>
        /// 获取或设置设备唯一序列号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sn")]
        [System.Text.Json.Serialization.JsonPropertyName("sn")]
        public string SerialNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置设备型号 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("model_id")]
        [System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string ModelId { get; set; } = string.Empty;
    }
}
