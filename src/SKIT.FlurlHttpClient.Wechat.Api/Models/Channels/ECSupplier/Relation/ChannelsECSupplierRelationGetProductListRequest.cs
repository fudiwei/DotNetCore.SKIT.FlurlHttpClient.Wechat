namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/supplier/relation/get_product_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECSupplierRelationGetProductListRequest : WechatApiRequest, IInferable<ChannelsECSupplierRelationGetProductListRequest, ChannelsECSupplierRelationGetProductListResponse>
    {
        /// <summary>
        /// 获取或设置是否过滤分配状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_filter_distribute_status")]
        [System.Text.Json.Serialization.JsonPropertyName("is_filter_distribute_status")]
        public bool? IsFilterDistributeStatus { get; set; }

        /// <summary>
        /// 获取或设置分配状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distribute_status")]
        [System.Text.Json.Serialization.JsonPropertyName("distribute_status")]
        public int? DistributeStatus { get; set; }

        /// <summary>
        /// 获取或设置是否过滤商品状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_filter_product_status")]
        [System.Text.Json.Serialization.JsonPropertyName("is_filter_product_status")]
        public bool? IsFilterProductStatus { get; set; }

        /// <summary>
        /// 获取或设置商品状态。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_status")]
        [System.Text.Json.Serialization.JsonPropertyName("product_status")]
        public int? ProductStatus { get; set; }

        /// <summary>
        /// 获取或设置是否过滤供货商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_filter_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("is_filter_supplier_appid")]
        public bool? IsFilterSupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置供货商 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("supplier_appid")]
        public string? SupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_context")]
        [System.Text.Json.Serialization.JsonPropertyName("page_context")]
        public string? Cursor { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit")]
        [System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }
    }
}
