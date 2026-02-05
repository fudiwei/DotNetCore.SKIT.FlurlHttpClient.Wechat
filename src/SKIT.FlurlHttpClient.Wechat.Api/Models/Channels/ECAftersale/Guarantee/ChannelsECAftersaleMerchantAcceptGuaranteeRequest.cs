namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/merchantacceptguarantee 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleMerchantAcceptGuaranteeRequest : WechatApiRequest, IInferable<ChannelsECAftersaleMerchantAcceptGuaranteeRequest, ChannelsECAftersaleMerchantAcceptGuaranteeResponse>
    {
        /// <summary>
        /// 获取或设置保障单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("guarantee_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("guarantee_order_id")]
        public long GuaranteeOrderId { get; set; }
    }
}
