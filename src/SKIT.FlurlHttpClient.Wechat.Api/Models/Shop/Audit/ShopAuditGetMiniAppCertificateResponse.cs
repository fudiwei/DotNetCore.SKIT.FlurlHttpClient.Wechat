namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/audit/get_miniapp_certificate 接口的响应。</para>
    /// </summary>
    public class ShopAuditGetMiniAppCertificateResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Brand
            {
                /// <summary>
                /// 获取或设置商标或品牌词。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_wording")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_wording")]
                public string BrandWording { get; set; } = default!;

                /// <summary>
                /// 获取或设置销售授权书图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sale_authorization")]
                [System.Text.Json.Serialization.JsonPropertyName("sale_authorization")]
                public string[]? SaleAuthorizationUrlList { get; set; }

                /// <summary>
                /// 获取或设置商标注册证书图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trademark_registration_certificate")]
                [System.Text.Json.Serialization.JsonPropertyName("trademark_registration_certificate")]
                public string[]? TrademarkRegistrationCertificateUrlList { get; set; }
            }

            public class Category
            {
                /// <summary>
                /// 获取或设置一级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("first_category_id")]
                public int FirstCategoryId { get; set; }

                /// <summary>
                /// 获取或设置一级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("first_category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("first_category_name")]
                public string FirstCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置二级类目 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_category_id")]
                [System.Text.Json.Serialization.JsonPropertyName("second_category_id")]
                public int SecondCategroyId { get; set; }

                /// <summary>
                /// 获取或设置二级类目名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("second_category_name")]
                [System.Text.Json.Serialization.JsonPropertyName("second_category_name")]
                public string SecondCategoryName { get; set; } = default!;

                /// <summary>
                /// 获取或设置资质材料图片 URL 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("certificate_url")]
                [System.Text.Json.Serialization.JsonPropertyName("certificate_url")]
                public string[]? QualificationUrlList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand_info")]
        [System.Text.Json.Serialization.JsonPropertyName("brand_info")]
        public Types.Brand? Brand { get; set; }

        /// <summary>
        /// 获取或设置分类列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_info_list")]
        [System.Text.Json.Serialization.JsonPropertyName("category_info_list")]
        public Types.Category[]? CategoryList { get; set; }
    }
}
