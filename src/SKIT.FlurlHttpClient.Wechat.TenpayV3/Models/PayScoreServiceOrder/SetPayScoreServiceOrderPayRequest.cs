using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /payscore/serviceorder/{out_order_no}/pay 接口的请求。</para>
    /// </summary>
    public class SetPayScoreServiceOrderPayRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Payment : CreatePayScoreServiceOrderRequest.Types.Payment
            {
            }

            public class Discount : CreatePayScoreServiceOrderRequest.Types.Discount
            {
            }

            public class Location
            {
                /// <summary>
                /// 获取或设置服务结束地点。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_location")]
                [System.Text.Json.Serialization.JsonPropertyName("end_location")]
                public string EndLocation { get; set; } = string.Empty;
            }
        }

        /// <summary>
        /// 获取或设置商户服务订单号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string OutOrderNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置服务 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("service_id")]
        [System.Text.Json.Serialization.JsonPropertyName("service_id")]
        public string ServiceId { get; set; } = string.Empty;
    }
}
