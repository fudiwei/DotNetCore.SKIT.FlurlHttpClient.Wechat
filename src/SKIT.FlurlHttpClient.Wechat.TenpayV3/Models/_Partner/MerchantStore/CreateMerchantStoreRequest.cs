using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /merchant-store/stores 接口的请求。</para>
    /// </summary>
    public class CreateMerchantStoreRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Basic
            {
                /// <summary>
                /// 获取或设置商家门店编号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_reference_id")]
                [System.Text.Json.Serialization.JsonPropertyName("store_reference_id")]
                public string? StoreReferenceId { get; set; }

                /// <summary>
                /// 获取或设置品牌名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_name")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                public string BrandName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("store_name")]
                [System.Text.Json.Serialization.JsonPropertyName("store_name")]
                public string StoreName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置分店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("branch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("branch_name")]
                public string? BranchName { get; set; }
            }

            public class Address
            {
                /// <summary>
                /// 获取或设置门店省市编码。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_code")]
                [System.Text.Json.Serialization.JsonPropertyName("address_code")]
                public string? AddressCode { get; set; }

                /// <summary>
                /// 获取或设置门店地址。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_detail")]
                [System.Text.Json.Serialization.JsonPropertyName("address_detail")]
                public string AddressDetail { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店地址辅助描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("address_complements")]
                [System.Text.Json.Serialization.JsonPropertyName("address_complements")]
                public string? AddressComplements { get; set; }

                /// <summary>
                /// 获取或设置门店经度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("longitude")]
                [System.Text.Json.Serialization.JsonPropertyName("longitude")]
                public string? Longitude { get; set; }

                /// <summary>
                /// 获取或设置门店纬度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("latitude")]
                [System.Text.Json.Serialization.JsonPropertyName("latitude")]
                public string? Latitude { get; set; }
            }

            public class Business
            {
                /// <summary>
                /// 获取或设置门店服务电话。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("service_phone")]
                [System.Text.Json.Serialization.JsonPropertyName("service_phone")]
                public string? ServicePhoneNumber { get; set; }

                /// <summary>
                /// 获取或设置门店经营时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("business_hours")]
                [System.Text.Json.Serialization.JsonPropertyName("business_hours")]
                public string? BusinessHours { get; set; }
            }

            public class Recipient
            {
                /// <summary>
                /// 获取或设置门店收款商户号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mchid")]
                [System.Text.Json.Serialization.JsonPropertyName("mchid")]
                public string MerchantId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置门店收款主体。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("company_name")]
                [System.Text.Json.Serialization.JsonPropertyName("company_name")]
                public string? CompanyName { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string? SubMerchantId { get; set; }

        /// <summary>
        /// 获取或设置门店基础信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_basics")]
        [System.Text.Json.Serialization.JsonPropertyName("store_basics")]
        public Types.Basic Basic { get; set; } = new Types.Basic();

        /// <summary>
        /// 获取或设置门店地址信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_address")]
        [System.Text.Json.Serialization.JsonPropertyName("store_address")]
        public Types.Address Address { get; set; } = new Types.Address();

        /// <summary>
        /// 获取或设置门店经营信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_business")]
        [System.Text.Json.Serialization.JsonPropertyName("store_business")]
        public Types.Business Business { get; set; } = new Types.Business();

        /// <summary>
        /// 获取或设置门店收款信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("store_recipient")]
        [System.Text.Json.Serialization.JsonPropertyName("store_recipient")]
        public IList<Types.Recipient>? RecipientList { get; set; }
    }
}
