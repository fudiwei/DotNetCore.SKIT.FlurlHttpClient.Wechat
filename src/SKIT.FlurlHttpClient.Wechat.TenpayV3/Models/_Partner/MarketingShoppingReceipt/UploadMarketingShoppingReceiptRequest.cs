using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /marketing/shopping-receipt/shoppingreceipts 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class UploadMarketingShoppingReceiptRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class MerchantContactInformation
            {
                /// <summary>
                /// 获取或设置售后咨询电话（需使用平台公钥/证书加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("consultation_phone_number")]
                [System.Text.Json.Serialization.JsonPropertyName("consultation_phone_number")]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                public string? ConsultationPhoneNumber { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置文件名（必须以 jpg、png 为后缀）。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置文件摘要。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sha256")]
        [System.Text.Json.Serialization.JsonPropertyName("sha256")]
        public string? FileHash { get; set; }

        /// <summary>
        /// 获取或设置文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }

        /// <summary>
        /// 获取或设置微信支付订单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transaction_id")]
        [System.Text.Json.Serialization.JsonPropertyName("transaction_id")]
        public string TransactionId { get; set; } = string.Empty;

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
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置与商家的联系渠道信息。
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
    }
}
