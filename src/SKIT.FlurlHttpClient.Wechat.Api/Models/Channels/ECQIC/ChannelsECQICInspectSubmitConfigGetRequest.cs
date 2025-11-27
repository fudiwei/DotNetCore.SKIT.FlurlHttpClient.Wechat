namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/qic/inspect/submitconfig/get 接口的请求。</para>
    /// </summary>
    public class ChannelsECQICInspectSubmitConfigGetRequest : WechatApiRequest, IInferable<ChannelsECQICInspectSubmitConfigGetRequest, ChannelsECQICInspectSubmitConfigGetResponse>
    {
        /// <summary>
        /// 获取或设置订单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }
    }
}
