namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/set_all_distribution 接口的请求。</para>
    /// </summary>
    public class ChannelsECSupplierRelationSetAllDistributeRequest : WechatApiRequest, IInferable<ChannelsECSupplierRelationSetAllDistributeRequest, ChannelsECSupplierRelationSetAllDistributeResponse>
    {
        /// <summary>
        /// 获取或设置全店订单自动分配的供货商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_appid")]
        public string SupplierAppId { get; set; } = string.Empty;
    }
}
