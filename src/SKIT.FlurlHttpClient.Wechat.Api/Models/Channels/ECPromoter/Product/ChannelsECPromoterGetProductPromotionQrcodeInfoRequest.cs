namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/promoter/get_product_promotion_qrcode_info 接口的请求。</para>
    /// </summary>
    public class ChannelsECPromoterGetProductPromotionQrcodeInfoRequest : WechatApiRequest, IInferable<ChannelsECPromoterGetProductPromotionQrcodeInfoRequest, ChannelsECPromoterGetProductPromotionQrcodeInfoResponse>
    {
        /// <summary>
        /// 获取或设置推客的微信电商平台注册的身份标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_appid")]
        public string? SharerAppId { get; set; }

        /// <summary>
        /// 获取或设置推客的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sharer_openid")]
        [System.Text.Json.Serialization.JsonPropertyName("sharer_openid")]
        public string? SharerOpenId { get; set; }

        /// <summary>
        /// 获取或设置小店 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_appid")]
        public string? ShopAppId { get; set; }

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
        public long? ProductId { get; set; }

        /// <summary>
        /// 获取或设置商品短链。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_short_link")]
        [System.Text.Json.Serialization.JsonPropertyName("product_short_link")]
        public string? ProductShortLink { get; set; }
    }
}
