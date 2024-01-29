namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_vip_score_exchange 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/vip/callback/score/user_score_exchange.html </para>
    /// </summary>
    public class ChannelsECVipScoreExchangeEvent : WechatApiEvent
    {
        public static class Types
        {
            public class Exchange
            {
                public static class Types
                {
                    public class Coupon
                    {
                        /// <summary>
                        /// 获取或设置优惠券 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("related_coupon_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("related_coupon_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        [System.Xml.Serialization.XmlElement("related_coupon_id")]
                        public long CouponId { get; set; }
                    }

                    public class Product
                    {
                        /// <summary>
                        /// 获取或设置商品 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("related_product_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("related_product_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        [System.Xml.Serialization.XmlElement("related_product_id")]
                        public long CouponId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置兑换类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("score_item_type")]
                [System.Text.Json.Serialization.JsonPropertyName("score_item_type")]
                [System.Xml.Serialization.XmlElement("score_item_type")]
                public int ScoreItemType { get; set; }

                /// <summary>
                /// 获取或设置兑换积分。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pay_score")]
                [System.Text.Json.Serialization.JsonPropertyName("pay_score")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("pay_score")]
                public int PayScore { get; set; }

                /// <summary>
                /// 获取或设置兑换的优惠券信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_info")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_info")]
                [System.Xml.Serialization.XmlElement("coupon_info", IsNullable = true)]
                public Types.Coupon? Coupon { get; set; }

                /// <summary>
                /// 获取或设置兑换的商品信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("product_info")]
                [System.Text.Json.Serialization.JsonPropertyName("product_info")]
                [System.Xml.Serialization.XmlElement("product_info", IsNullable = true)]
                public Types.Product? Product { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置兑换信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exchange_info")]
        [System.Text.Json.Serialization.JsonPropertyName("exchange_info")]
        [System.Xml.Serialization.XmlElement("exchange_info")]
        public Types.Exchange Exchange { get; set; } = default!;
    }
}
