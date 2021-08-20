using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/local/business/update_order 接口的请求。</para>
    /// </summary>
    public class CgibinExpressLocalBusinessUpdateOrderRequest : CgibinExpressLocalBusinessRealMockUpdateOrderRequest
    {
        public static class Types
        {
            public class Agent
            {
                /// <summary>
                /// 获取或设置骑手姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置骑手电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("phone")]
                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                public string PhoneNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置电话是否加密。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("is_phone_encrypted")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.NumericalNullableBooleanConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("is_phone_encrypted")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalNullableBooleanConverter))]
                public bool? IsPhoneEncrypted { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置微信订单 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wx_token")]
        [System.Text.Json.Serialization.JsonPropertyName("wx_token")]
        public string Token { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_no")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_no")]
        public string? ShopNumber { get; set; }

        /// <summary>
        /// 获取或设置配送单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_id")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_id")]
        public string WaybillId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置配送公司小程序跳转路径。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wxa_path")]
        [System.Text.Json.Serialization.JsonPropertyName("wxa_path")]
        public string MiniProgramPagePath { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置骑手信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("agent")]
        [System.Text.Json.Serialization.JsonPropertyName("agent")]
        public Types.Agent? Agent { get; set; }

        /// <summary>
        /// 获取或设置预计送达时间戳。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expected_delivery_time")]
        [System.Text.Json.Serialization.JsonPropertyName("expected_delivery_time")]
        public long? ExpectedDeliveryTimestamp { get; set; }
    }
}
