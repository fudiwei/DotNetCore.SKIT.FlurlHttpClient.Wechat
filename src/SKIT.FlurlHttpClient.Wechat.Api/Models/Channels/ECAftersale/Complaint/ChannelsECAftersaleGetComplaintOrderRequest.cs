namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/getcomplaintorder 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleGetComplaintOrderRequest : WechatApiRequest, IInferable<ChannelsECAftersaleGetComplaintOrderRequest, ChannelsECAftersaleGetComplaintOrderResponse>
    {
        /// <summary>
        /// 获取或设置纠纷单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("complaint_id")]
        [System.Text.Json.Serialization.JsonPropertyName("complaint_id")]
        public string ComplaintId { get; set; } = string.Empty;
    }
}
