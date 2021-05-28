using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Events
{
    /// <summary>
    /// <para>表示 MALL_REFUND.SUCCESS 通知的数据。</para>
    /// </summary>
    public class MallRefundResource : WechatTenpayEvent.Types.IDecryptedResource
    {
        /// <summary>
        /// 获取或设置微信商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("mchid")]
        public string MerchantId { get; set; } = default!;

        /// <summary>
        /// 获取或设置商圈商户名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_name")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
        public string MerchantName { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_name")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_name")]
        public string ShopName { get; set; } = default!;

        /// <summary>
        /// 获取或设置门店编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_number")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_number")]
        public string ShopNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string AppId { get; set; } = default!;

        /// <summary>
        /// 获取或设置用户唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = default!;

        /// <summary>
        /// 获取或设置微信支付退款号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = default!;

        /// <summary>
        /// 获取或设置消费金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_amount")]
        public int PayAmount { get; set; }

        /// <summary>
        /// 获取或设置退款金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_amount")]
        public int RefundAmount { get; set; }

        /// <summary>
        /// 获取或设置退款成功时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("refund_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset SuccessTime { get; set; }
    }
}
