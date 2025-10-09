using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /brand/partner/card-member/user-cards/{user_card_code} 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class UpdateBrandPartnerCardMemberUserCardRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ValidDateInfo : UpdateBrandPartnerCardMemberCardRequest.Types.ValidDateInfo
            {
            }

            public class UserInfo
            {
                public static class Types
                {
                    public class CommonField
                    {
                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段值（需使用平台公钥/证书加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("value")]
                        [System.Text.Json.Serialization.JsonPropertyName("value")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public string? Value { get; set; }
                    }

                    public class CustomField
                    {
                        /// <summary>
                        /// 获取或设置字段名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置字段值（需使用平台公钥/证书加密）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("user_chosen_values")]
                        [System.Text.Json.Serialization.JsonPropertyName("user_chosen_values")]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
                        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
                        public IList<string>? Values { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置通用开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("common_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("common_field_list")]
                public IList<Types.CommonField>? CommonFieldList { get; set; }

                /// <summary>
                /// 获取或设置自定义开卡信息字段列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("custom_field_list")]
                [System.Text.Json.Serialization.JsonPropertyName("custom_field_list")]
                public IList<Types.CustomField>? CustomFieldList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置会员卡 Code。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UserCardCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡模板 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置品牌 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_id")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
        public string BrandId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置会员卡背景颜色。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_color")]
        [System.Text.Json.Serialization.JsonPropertyName("card_color")]
        public string? CardColor { get; set; }

        /// <summary>
        /// 获取或设置会员卡图片 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_picture_url")]
        [System.Text.Json.Serialization.JsonPropertyName("card_picture_url")]
        public string? CardPictureUrl { get; set; }

        /// <summary>
        /// 获取或设置用户的手机号码（需使用平台公钥/证书加密）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("phone_number")]
        [System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_RSA_2048_WITH_SHA256, algorithm: Constants.EncryptionAlgorithms.RSA_2048_ECB_PKCS8_OAEP_WITH_SHA1_AND_MGF1)]
        [WechatTenpaySensitiveProperty(scheme: Constants.SignSchemes.WECHATPAY2_SM2_WITH_SM3, algorithm: Constants.EncryptionAlgorithms.SM2_C1C3C2_ASN1)]
        public string? MobileNumber { get; set; }

        /// <summary>
        /// 获取或设置会员等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("level")]
        [System.Text.Json.Serialization.JsonPropertyName("level")]
        public string? Level { get; set; }

        /// <summary>
        /// 获取或设置会员卡有效期信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_date_information")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_date_information")]
        public Types.ValidDateInfo? ValidDateInfo { get; set; }

        /// <summary>
        /// 获取或设置用户开卡信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("user_information")]
        [System.Text.Json.Serialization.JsonPropertyName("user_information")]
        public Types.UserInfo? UserInfo { get; set; }

        /// <summary>
        /// 获取或设置附加数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("attach")]
        [System.Text.Json.Serialization.JsonPropertyName("attach")]
        public string? Attachment { get; set; }
    }
}
