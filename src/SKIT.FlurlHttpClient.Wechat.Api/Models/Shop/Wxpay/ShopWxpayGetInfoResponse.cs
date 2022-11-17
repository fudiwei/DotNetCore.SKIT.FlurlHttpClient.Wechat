namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/wxpay/get_info 接口的响应。</para>
    /// </summary>
    public class ShopWxpayGetInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class PayRequest
            {
                public static class Types
                {
                    public class BusinessLicense
                    {
                        /// <summary>
                        /// 获取或设置商户名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("merchant_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("merchant_name")]
                        public string MerchantName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置营业执照编号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("business_license_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("business_license_number")]
                        public string BusinessLicenseNumber { get; set; } = default!;
                    }

                    public class Contact
                    {
                        /// <summary>
                        /// 获取或设置联系人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_name")]
                        public string UserName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系人身份证号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact_id_card_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact_id_card_number")]
                        public string IdCardNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile_phone")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile_phone")]
                        public string MobileNumber { get; set; } = default!;
                    }

                    public class SaleScene
                    {
                        /// <summary>
                        /// 获取或设置店铺名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                        public string? StoreName { get; set; }

                        /// <summary>
                        /// 获取或设置店铺链接。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("store_url")]
                        [System.Text.Json.Serialization.JsonPropertyName("store_url")]
                        public string? StoreUrl { get; set; }

                        /// <summary>
                        /// 获取或设置子商户小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mini_program_sub_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("mini_program_sub_appid")]
                        public string? MiniProgramSubAppId { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置主体类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organization_type")]
                [System.Text.Json.Serialization.JsonPropertyName("organization_type")]
                public int SubjectType { get; set; }

                /// <summary>
                /// 获取或设置营业执照信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_license_info")]
                [System.Text.Json.Serialization.JsonPropertyName("business_license_info")]
                public Types.BusinessLicense BusinessLicense { get; set; } = new Types.BusinessLicense();

                /// <summary>
                /// 获取或设置联系人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("contact_info")]
                [System.Text.Json.Serialization.JsonPropertyName("contact_info")]
                public Types.Contact Contact { get; set; } = default!;

                /// <summary>
                /// 获取或设置商户简称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("merchant_shortname")]
                [System.Text.Json.Serialization.JsonPropertyName("merchant_shortname")]
                public string? MerchantShortName { get; set; }

                /// <summary>
                /// 获取或设置销售场景信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sales_scene_info")]
                [System.Text.Json.Serialization.JsonPropertyName("sales_scene_info")]
                public Types.SaleScene? SaleScene { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置进件信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_req")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_req")]
        public Types.PayRequest PayRequest { get; set; } = default!;
    }
}
