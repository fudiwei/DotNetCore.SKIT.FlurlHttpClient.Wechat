namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/aftersale/acceptapply 接口的请求。</para>
    /// </summary>
    public class ChannelsECAftersaleAcceptApplyRequest : WechatApiRequest, IInferable<ChannelsECAftersaleAcceptApplyRequest, ChannelsECAftersaleAcceptApplyResponse>
    {
        /// <summary>
        /// 获取或设置售后单 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("after_sale_order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("after_sale_order_id")]
        public string AftersaleOrderId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置地址 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address_id")]
        [System.Text.Json.Serialization.JsonPropertyName("address_id")]
        public long? AddressId { get; set; }

        /// <summary>
        /// 获取或设置同意场景类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("accept_type")]
        [System.Text.Json.Serialization.JsonPropertyName("accept_type")]
        public int? AcceptType { get; set; }
    }
}
