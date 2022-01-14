namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/submerchant/get 接口的响应。</para>
    /// </summary>
    public class CardSubMerchantGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SubMerchant
            {
                /// <summary>
                /// 获取或设置子商户 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_id")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.NumericalStringConverter))]
                public string MerchantId { get; set; } = default!;

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
                public string BrandName { get; set; } = default!;

                /// <summary>
                /// 获取或设置子商户 Logo Url。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("logo_url")]
                [System.Text.Json.Serialization.JsonPropertyName("logo_url")]
                public string LogoUrl { get; set; } = default!;

                /// <summary>
                /// 获取或设置子商户状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;

                /// <summary>
                /// 获取或设置授权函有效期开始时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("begin_time")]
                [System.Text.Json.Serialization.JsonPropertyName("begin_time")]
                public long BeginTimestamp { get; set; }

                /// <summary>
                /// 获取或设置授权函有效期截止时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("end_time")]
                [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                public long EndTimestamp { get; set; }

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

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.SubMerchant SubMerchant { get; set; } = default!;
    }
}
