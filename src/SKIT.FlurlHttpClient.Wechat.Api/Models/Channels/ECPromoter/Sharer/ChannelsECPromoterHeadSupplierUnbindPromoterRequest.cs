namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/headsupplier_unbind_promoter 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterHeadSupplierUnbindPromoterRequest : WechatApiRequest, IInferable<ChannelsECPromoterHeadSupplierUnbindPromoterRequest, ChannelsECPromoterHeadSupplierUnbindPromoterResponse>
    {
        /// <summary>
        /// 获取或设置推客的微信电商平台注册的身份标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string SharerAppId { get; set; } = string.Empty;
    }
}
