using System;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /certificates 接口的响应。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class QueryCertificatesResponse : WechatTenpayResponse
    {
        public static class Types
        {
            public class Certificate
            {
                public static class Types
                {
                    public class EncryptCertificate
                    {
                        /// <summary>
                        /// 获取或设置加密算法。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("algorithm")]
                        [System.Text.Json.Serialization.JsonPropertyName("algorithm")]
                        public string Algorithm { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置加密使用的附加数据。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("associated_data")]
                        [System.Text.Json.Serialization.JsonPropertyName("associated_data")]
                        public string? AssociatedData { get; set; }

                        /// <summary>
                        /// 获取或设置加密使用的随机串初始化向量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nonce")]
                        [System.Text.Json.Serialization.JsonPropertyName("nonce")]
                        public string Nonce { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 Base64 编码后的密文（需使用商户 API v3 密钥解密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ciphertext")]
                        [System.Text.Json.Serialization.JsonPropertyName("ciphertext")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.AEAD_AES_256_GCM)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.AEAD_SM4_128_GCM)]
                        public string CipherText { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置证书生效时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("effective_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("effective_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset EffectiveTime { get; set; }

                /// <summary>
                /// 获取或设置证书过期时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("expire_time")]
                [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RFC3339DateTimeOffsetConverter))]
                [System.Text.Json.Serialization.JsonPropertyName("expire_time")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RFC3339DateTimeOffsetConverter))]
                public DateTimeOffset ExpireTime { get; set; }

                /// <summary>
                /// 获取或设置证书序列号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("serial_no")]
                [System.Text.Json.Serialization.JsonPropertyName("serial_no")]
                public string SerialNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置证书信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("encrypt_certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("encrypt_certificate")]
                public Types.EncryptCertificate EncryptCertificate { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置微信服务器证书列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Certificate[] CertificateList { get; set; } = default!;
    }
}
