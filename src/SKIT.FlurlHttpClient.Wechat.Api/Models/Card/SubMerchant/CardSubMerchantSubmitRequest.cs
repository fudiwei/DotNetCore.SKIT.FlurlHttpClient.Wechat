using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/submerchant/submit 接口的请求。</para>
    /// </summary>
    public class CardSubMerchantSubmitRequest : WechatApiRequest
    {
        public static class Types
        {
            public class SubMerchant
            {
                /// <summary>
                /// 获取或设置子商户的公众号 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_id")]
                [System.Text.Json.Serialization.JsonPropertyName("app_id")]
                public string? AppId { get; set; }

                /// <summary>
                /// 获取或设置子商户名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_name")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                public string BrandName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置子商户 Logo Url。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
                public string LogoUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置授权函 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("protocol")]
                [System.Text.Json.Serialization.JsonPropertyName("protocol")]
                public string AuthorizationLetterMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置授权函有效截止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long AuthorizationLetterEndTimestamp { get; set; }

                /// <summary>
                /// 获取或设置营业执照 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("agreement_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("agreement_media_id")]
                public string? BusinessLicenseMediaId { get; set; }

                /// <summary>
                /// 获取或设置法人 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("operator_media_id")]
                [System.Text.Json.Serialization.JsonPropertyName("operator_media_id")]
                public string? LegalPersonMediaId { get; set; }

                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("primary_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("primary_category_id")]
                public int PrimaryCategoryId { get; set; }

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("secondary_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("secondary_category_id")]
                public int SecondaryCategoryId { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.SubMerchant SubMerchant { get; set; } = new Types.SubMerchant();
    }
}
