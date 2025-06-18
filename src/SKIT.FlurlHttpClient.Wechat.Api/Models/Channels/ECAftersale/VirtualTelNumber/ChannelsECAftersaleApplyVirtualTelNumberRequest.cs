namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/applyvirtualtelnum 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleApplyVirtualTelNumberRequest : WechatApiRequest, IInferable<ChannelsECAftersaleApplyVirtualTelNumberRequest, ChannelsECAftersaleApplyVirtualTelNumberResponse>
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public string AftersaleOrderId { get; set; } = string.Empty;
    }
}
