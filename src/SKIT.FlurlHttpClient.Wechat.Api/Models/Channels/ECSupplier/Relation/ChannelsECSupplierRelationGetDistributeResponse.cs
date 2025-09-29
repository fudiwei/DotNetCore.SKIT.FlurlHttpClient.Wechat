namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/get_distribute 接口的响应。</para>
    /// </summary>
    public class ChannelsECSupplierRelationGetDistributeResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置分配类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distribute_type")]
        [System.Text.Json.Serialization.JsonPropertyName("distribute_type")]
        public int DistributeType { get; set; }

        /// <summary>
        /// 获取或设置全店订单自动分配的供货商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("all_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("all_supplier_appid")]
        public string? AllDistributeSupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置全店订单自动分配的供货商名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("all_distribute_supplier_name")]
        [System.Text.Json.Serialization.JsonPropertyName("all_distribute_supplier_name")]
        public string? AllDistributeSupplierName { get; set; }
    }
}
