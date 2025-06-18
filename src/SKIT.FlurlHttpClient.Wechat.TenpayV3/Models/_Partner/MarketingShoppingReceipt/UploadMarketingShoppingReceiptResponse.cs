using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/shopping-receipt/shoppingreceipts 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class UploadMarketingShoppingReceiptResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Receipt
            {
                public static class Types
                {
                    public class MerchantContactInformation
                    {
                        /// <summary>
                        /// 获取或设置售后咨询电话（需使用商户私钥解密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("consultation_phone_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("consultation_phone_number")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? ConsultationPhoneNumber { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置电子小票 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("receipt_id")]
                [System.Text.Json.Serialization.JsonPropertyName("receipt_id")]
                public string ReceiptId { get; set; } = default!;

                /// <summary>
                /// 获取或设置审核状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string State { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件图片类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("image_type")]
                [System.Text.Json.Serialization.JsonPropertyName("image_type")]
                public string FileImageType { get; set; } = default!;

                /// <summary>
                /// 获取或设置文件摘要。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sha256")]
                [System.Text.Json.Serialization.JsonPropertyName("sha256")]
                public string FileHash { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_id")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
                public string TransactionId { get; set; } = default!;

                /// <summary>
                /// 获取或设置微信支付商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_mchid")]
                public string? TransactionMerchantId { get; set; }

                /// <summary>
                /// 获取或设置微信支付子商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("transaction_sub_mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("transaction_sub_mchid")]
                public string? TransactionSubMerchantId { get; set; }

                /// <summary>
                /// 获取或设置商户订单号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("out_trade_no")]
                [System.Text.Json.Serialization.JsonPropertyName("out_trade_no")]
                public string? OutTradeNumber { get; set; }

                /// <summary>
                /// 获取或设置用户 OpenId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("openid")]
                [System.Text.Json.Serialization.JsonPropertyName("openid")]
                public string OpenId { get; set; } = default!;

                /// <summary>
                /// 获取或设置与商家的联系渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_contact_information")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_contact_information")]
                public Types.MerchantContactInformation? MerchantContactInformation { get; set; }

                /// <summary>
                /// 获取或设置上传时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("upload_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("upload_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset? UploadTime { get; set; }

                /// <summary>
                /// 获取或设置创建时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset CreateTime { get; set; }

                /// <summary>
                /// 获取或设置修改时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("modify_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.Rfc3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("modify_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.Rfc3339DateTimeOffsetConverter))]
                public DateTimeOffset ModifyTime { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置电子小票信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receipt")]
        [System.Text.Json.Serialization.JsonPropertyName("receipt")]
        public Types.Receipt Receipt { get; set; } = default!;
    }
}
