namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/get_product_default_distribute 接口的响应。</para>
    /// </summary>
    public class ChannelsECSupplierRelationGetProductDefaultDistributionResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置是否存在已设置自动分配的供货商。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exist_default_supplier")]
        [System.Text.Json.Serialization.JsonPropertyName("exist_default_supplier")]
        public bool IsExistDefaultSupplier { get; set; }

        /// <summary>
        /// 获取或设置自动分配的供货商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_appid")]
        public string? SupplierAppId { get; set; }
    }
}
