using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/order/add 接口的响应。</para>
    /// </summary>
    public class ShopOrderAddResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                public long OrderId { get; set; }

                /// <summary>
                /// 获取或设置商家自定义订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("out_order_id")]
                public string OutOrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置拉起收银台的票据。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket")]
                [System.Text.Json.Serialization.JsonPropertyName("ticket")]
                public string Ticket { get; set; } = default!;

                /// <summary>
                /// 获取或设置拉起收银台的票据有效时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ticket_expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("ticket_expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularDateTimeOffsetConverter))]
                public DateTimeOffset TicketExpireTime { get; set; }

                /// <summary>
                /// 获取或设置订单最终价格（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("final_price")]
                [System.Text.Json.Serialization.JsonPropertyName("final_price")]
                public int FinalFee { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
