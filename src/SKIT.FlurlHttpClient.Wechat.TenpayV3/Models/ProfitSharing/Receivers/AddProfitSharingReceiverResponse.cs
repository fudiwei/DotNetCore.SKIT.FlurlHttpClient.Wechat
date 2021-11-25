using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /profitsharing/receivers/add 接口的响应。</para>
    /// </summary>
    public class AddProfitSharingReceiverResponse : WechatTenpayResponse
    {
        /// <summary>
        /// 获取或设置微信子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置接收方类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type")]
        [System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收方账户。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account")]
        [System.Text.Json.Serialization.JsonPropertyName("account")]
        public string Account { get; set; } = default!;

        /// <summary>
        /// 获取或设置接收方名称（需使用商户私钥解密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        [WechatTenpaySensitiveProperty(algorithm: Constants.EncryptionAlgorithms.RSA_2048_PKCS8_ECB)]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置与分账方的关系类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("relation_type")]
        [System.Text.Json.Serialization.JsonPropertyName("relation_type")]
        public string RelationType { get; set; } = default!;

        /// <summary>
        /// 获取或设置自定义的分账关系。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("custom_relation")]
        [System.Text.Json.Serialization.JsonPropertyName("custom_relation")]
        public string? CustomRelation { get; set; }
    }
}
