namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 BRAND_MEMBER_CARD_SP.POINT_EXCHANGE_COUPON （仅限服务商）通知的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://pay.weixin.qq.com/doc/v3/partner/4015878622 ]]>
    /// </para>
    /// </summary>
    public class BrandPartnerCardMemberPointExchangeCouponResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置积分兑券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("record_id")]
        [System.Text.Json.Serialization.JsonPropertyName("record_id")]
        public string RecordId { get; set; } = default!;

        /// <summary>
        /// 获取或设置积分兑券模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exchange_coupon_template_id")]
        [System.Text.Json.Serialization.JsonPropertyName("exchange_coupon_template_id")]
        public string ExchangeCouponTemplateId { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_card_code")]
        [System.Text.Json.Serialization.JsonPropertyName("user_card_code")]
        public string UserCardCode { get; set; } = default!;

        /// <summary>
        /// 获取或设置会员卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = default!;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商家 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置消耗积分数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deduct_points")]
        [System.Text.Json.Serialization.JsonPropertyName("deduct_points")]
        public int DeductPoints { get; set; }

        /// <summary>
        /// 获取或设置商品券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon_id")]
        public string ProductCouponId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品券批次类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("product_coupon_stock_type")]
        [System.Text.Json.Serialization.JsonPropertyName("product_coupon_stock_type")]
        public string ProductCouponStockType { get; set; } = default!;

        /// <summary>
        /// 获取或设置商品券批次 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = default!;
    }
}
