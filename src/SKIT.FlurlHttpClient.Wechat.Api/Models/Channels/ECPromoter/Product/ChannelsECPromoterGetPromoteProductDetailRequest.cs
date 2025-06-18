namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_promote_product_detail 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetPromoteProductDetailRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetPromoteProductDetailRequest, ChannelsECPromoterGetPromoteProductDetailResponse>
    {
        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string ShopAppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置供货机构 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("head_supplier_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("head_supplier_appid")]
        public string? HeadSupplierAppId { get; set; }

        /// <summary>
        /// 获取或设置商品 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_id")]
        public long ProductId { get; set; }

        /// <summary>
        /// 获取或设置计划类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plan_type")]
        [System.Text.Json.Serialization.JsonPropertyName("plan_type")]
        public int PlanType { get; set; }

        /// <summary>
        /// 获取或设置是否返回商品可用的机构券。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("get_available_coupon")]
        [System.Text.Json.Serialization.JsonPropertyName("get_available_coupon")]
        public bool RequireAvailableCoupon { get; set; }
    }
}
