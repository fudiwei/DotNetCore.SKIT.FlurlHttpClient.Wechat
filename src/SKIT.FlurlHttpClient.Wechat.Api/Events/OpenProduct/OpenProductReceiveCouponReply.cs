using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Events
{
    /// <summary>
    /// <para>表示被动回复用户领券通知的数据。</para>
    /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/platform-capabilities/business-capabilities/ministore/minishopopencomponent2/callback/receive_coupon.html </para>
    /// </summary>
    public class OpenProductReceiveCouponReply : WechatApiEvent, WechatApiEvent.Serialization.IJsonSerializable, WechatApiEvent.Serialization.IXmlSerializable
    {
        /// <summary>
        /// 获取或设置返回状态码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret_code")]
        [System.Text.Json.Serialization.JsonPropertyName("ret_code")]
        [System.Xml.Serialization.XmlElement("ret_code")]
        public int ReturnCode { get; set; }

        /// <summary>
        /// 获取或设置返回描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ret_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("ret_msg")]
        [System.Xml.Serialization.XmlElement("ret_msg")]
        public string ReturnMessage { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家侧优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_coupon_id")]
        [System.Xml.Serialization.XmlElement("out_coupon_id", IsNullable = true)]
        public string? OutCouponId { get; set; }

        /// <summary>
        /// 获取或设置商家侧用户优惠券 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_user_coupon_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_user_coupon_id")]
        [System.Xml.Serialization.XmlElement("out_user_coupon_id", IsNullable = true)]
        public string? OutUserCouponId { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("request_id")]
        [System.Text.Json.Serialization.JsonPropertyName("request_id")]
        [System.Xml.Serialization.XmlElement("request_id", IsNullable = true)]
        public string? RequestId { get; set; }
    }
}
