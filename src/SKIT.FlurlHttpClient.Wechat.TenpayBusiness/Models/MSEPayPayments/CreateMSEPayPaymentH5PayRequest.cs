﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/payments/h5-pay 接口的请求。</para>
    /// </summary>
    [WechatTenpayBusinessSensitive]
    public class CreateMSEPayPaymentH5PayRequest : WechatTenpayBusinessRequest
    {
        public static class Types
        {
            public class Payee
            {
                /// <summary>
                /// 获取或设置企业 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ent_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
                public string EnterpriseId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置企业名称（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ent_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ent_name")]
                [WechatTenpayBusinessSensitiveProperty]
                public string EnterpriseName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置企业账户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ent_acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("ent_acct_id")]
                public string EnterpriseAccountId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行卡号后 4 位。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_number_last4")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_number_last4")]
                public string? BankAccountNumberLast4String { get; set; }
            }

            public class Goods
            {
                /// <summary>
                /// 获取或设置商品名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("good_name")]
                [System.Text.Json.Serialization.JsonPropertyName("good_name")]
                public string GoodsName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置商品数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("good_number")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("good_number")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public int Count { get; set; }

                /// <summary>
                /// 获取或设置商品金额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("good_amount")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.TextualIntegerConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("good_amount")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                public int Amount { get; set; }
            }

            public class NotifyConfig
            {
                /// <summary>
                /// 获取或设置支付结果通知 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("server_notify_url")]
                [System.Text.Json.Serialization.JsonPropertyName("server_notify_url")]
                public string ServerNotifyUrl { get; set; } = string.Empty;
            }

            public class RiskControl
            {
                /// <summary>
                /// 获取或设置设备号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("device_id")]
                [System.Text.Json.Serialization.JsonPropertyName("device_id")]
                public string? DeviceId { get; set; }

                /// <summary>
                /// 获取或设置用户终端 IP。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_client_ip")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_client_ip")]
                public string? ClientIp { get; set; }

                /// <summary>
                /// 获取或设置用户浏览器 User-Agent。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("payer_ua")]
                [System.Text.Json.Serialization.JsonPropertyName("payer_ua")]
                public string? ClientUserAgent { get; set; }

                /// <summary>
                /// 获取或设置下单时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339NullableDateTimeOffsetConverter))]
                public DateTimeOffset? CreateTime { get; set; }

                /// <summary>
                /// 获取或设置提货方式。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_type")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_type")]
                public string? PickType { get; set; }

                /// <summary>
                /// 获取或设置提货描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pick_description")]
                [System.Text.Json.Serialization.JsonPropertyName("pick_description")]
                public string? PickDescription { get; set; }
            }

            public class Promotion
            {
            }
        }

        /// <summary>
        /// 获取或设置付款类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("purchaser_type")]
        [System.Text.Json.Serialization.JsonPropertyName("purchaser_type")]
        public string PurchaserType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台支付单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_payment_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_payment_id")]
        public string OutPaymentId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置支付金额（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount")]
        [System.Text.Json.Serialization.JsonPropertyName("amount")]
        public int Amount { get; set; }

        /// <summary>
        /// 获取或设置币种。
        /// <para>默认值：CNY</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("currency")]
        [System.Text.Json.Serialization.JsonPropertyName("currency")]
        public string Currency { get; set; } = "CNY";

        /// <summary>
        /// 获取或设置过期时间。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expire_time")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
        public DateTimeOffset ExpireTime { get; set; }

        /// <summary>
        /// 获取或设置收款方信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("payee")]
        [System.Text.Json.Serialization.JsonPropertyName("payee")]
        public Types.Payee Payee { get; set; } = new Types.Payee();

        /// <summary>
        /// 获取或设置附言。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("memo")]
        [System.Text.Json.Serialization.JsonPropertyName("memo")]
        public string? Memo { get; set; }

        /// <summary>
        /// 获取或设置商品信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods")]
        [System.Text.Json.Serialization.JsonPropertyName("goods")]
        public IList<Types.Goods>? GoodsList { get; set; }

        /// <summary>
        /// 获取或设置附加信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attachment")]
        [System.Text.Json.Serialization.JsonPropertyName("attachment")]
        public string? Attachment { get; set; }

        /// <summary>
        /// 获取或设置风控信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("risk_control")]
        [System.Text.Json.Serialization.JsonPropertyName("risk_control")]
        public Types.RiskControl? RiskControl { get; set; }

        /// <summary>
        /// 获取或设置回调配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("notify_url")]
        [System.Text.Json.Serialization.JsonPropertyName("notify_url")]
        public Types.NotifyConfig NotifyConfig { get; set; } = new Types.NotifyConfig();

        /// <summary>
        /// 获取或设置优惠信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_detail")]
        public Types.Promotion? Promotion { get; set; }
    }
}
