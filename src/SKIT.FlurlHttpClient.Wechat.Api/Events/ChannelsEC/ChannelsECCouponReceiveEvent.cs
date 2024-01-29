namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示 EVENT.channels_ec_coupon_receive 事件的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/doc/channels/API/aftersale/ec_callback/channels_ec_aftersale_update.html </para>
    /// </summary>
    public class ChannelsECCouponReceiveEvent : WechatApiEvent
    {
        public static class Types
        {
            public class UserCoupon
            {
                /// <summary>
                /// 获取或设置用户优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("user_coupon_id")]
                [System.Xml.Serialization.XmlElement("user_coupon_id")]
                public string UserCouponId { get; set; } = default!;

                /// <summary>
                /// 获取或设置优惠券 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("coupon_id")]
                [System.Text.Json.Serialization.JsonPropertyName("coupon_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("coupon_id")]
                public long CouponId { get; set; }

                /// <summary>
                /// 获取或设置领券时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receive_time")]
                [System.Text.Json.Serialization.JsonPropertyName("receive_time")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                [System.Xml.Serialization.XmlElement("receive_time")]
                public long ReceiveTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置用户优惠券信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receive_info")]
        [System.Text.Json.Serialization.JsonPropertyName("receive_info")]
        [System.Xml.Serialization.XmlElement("receive_info")]
        public Types.UserCoupon UserCoupon { get; set; } = default!;
    }
}
