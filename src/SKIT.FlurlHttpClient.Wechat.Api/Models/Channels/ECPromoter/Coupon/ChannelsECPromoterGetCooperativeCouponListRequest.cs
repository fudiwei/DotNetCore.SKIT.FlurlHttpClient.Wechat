namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_cooperative_coupon_list 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetCooperativeCouponListRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetCooperativeCouponListRequest, ChannelsECPromoterGetCooperativeCouponListResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string? ShopAppId { get; set; }

        /// <summary>
        /// 获取或设置是否来源于其他机构。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_from_head_supplier")]
        [System.Text.Json.Serialization.JsonPropertyName("is_from_head_supplier")]
        public bool? IsFromHeadSupplier { get; set; }

        /// <summary>
        /// 获取或设置来源的机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("from_head_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("from_head_supplier_appid")]
        public string? FromHeadSupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置分页每页数量。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page_size")]
        [System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int PageSize { get; set; }

        /// <summary>
        /// 获取或设置分页游标。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("next_key")]
        [System.Text.Json.Serialization.JsonPropertyName("next_key")]
        public string? Cursor { get; set; }
    }
}
