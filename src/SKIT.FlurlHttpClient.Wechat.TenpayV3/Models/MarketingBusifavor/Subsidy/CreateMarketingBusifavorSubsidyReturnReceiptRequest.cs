using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/busifavor/subsidy/return-receipts 接口的请求。</para>
    /// </summary>
    public class CreateMarketingBusifavorSubsidyReturnReceiptRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置商家券批次号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stock_id")]
        [System.Text.Json.Serialization.JsonPropertyName("stock_id")]
        public string StockId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商家券 Code。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("coupon_code")]
        [System.Text.Json.Serialization.JsonPropertyName("coupon_code")]
        public string CouponCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信支付退款单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string RefundId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置营销补差扣款商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payer_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("payer_merchant")]
        public string? PayerMerchantId { get; set; }

        /// <summary>
        /// 获取或设置营销补差入账商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee_merchant")]
        [System.Text.Json.Serialization.JsonPropertyName("payee_merchant")]
        public string? PayeeMerchantId { get; set; }

        /// <summary>
        /// 获取或设置补差回退金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置补差回退描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务请求唯一单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_subsidy_return_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_subsidy_return_no")]
        public string OutSubsidyReturnNumber { get; set; } = string.Empty;
    }
}
