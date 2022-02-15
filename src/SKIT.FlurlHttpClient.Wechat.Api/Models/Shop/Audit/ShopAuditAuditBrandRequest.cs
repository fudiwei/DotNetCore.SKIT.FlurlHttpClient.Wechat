using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/audit/audit_brand 接口的请求。</para>
    /// </summary>
    public class ShopAuditAuditBrandRequest : WechatApiRequest, IMapResponse<ShopAuditAuditBrandRequest, ShopAuditAuditBrandResponse>
    {
        public static class Types
        {
            public class Audit
            {
                public static class Types
                {
                    public class Brand
                    {
                        /// <summary>
                        /// 获取或设置认证审核类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_audit_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_audit_type")]
                        public int BrandAuditType { get; set; }

                        /// <summary>
                        /// 获取或设置品牌经营类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_management_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_management_type")]
                        public int BrandManagementType { get; set; }

                        /// <summary>
                        /// 获取或设置商标分类。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_type")]
                        public string TrademarkType { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置商品产地类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("commodity_origin_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("commodity_origin_type")]
                        public int CommodityOriginType { get; set; }

                        /// <summary>
                        /// 获取或设置商标或品牌词。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_wording")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_wording")]
                        public string BrandWording { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置销售授权书图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sale_authorization")]
                        [System.Text.Json.Serialization.JsonPropertyName("sale_authorization")]
                        public IList<string>? SaleAuthorizationUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册证书图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_registration_certificate")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_registration_certificate")]
                        public IList<string>? TrademarkRegistrationCertificateUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置商标变更证明图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_change_certificate")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_change_certificate")]
                        public IList<string>? TrademarkChangeCertificateUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_registrant")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_registrant")]
                        public string? TrademarkRegistrant { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册号或申请号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_registrant_nu")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_registrant_nu")]
                        public string? TrademarkRegistrantNumber { get; set; }

                        /// <summary>
                        /// 获取或设置商标有效时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_authorization_period")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_authorization_period")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? TrademarkAuthorizationTime { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册申请受理通知书图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_registration_application")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_registration_application")]
                        public IList<string>? TrademarkRegistrationApplicationUrlList { get; set; }

                        /// <summary>
                        /// 获取或设置商标申请人姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_applicant")]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_applicant")]
                        public string? TrademarkApplicant { get; set; }

                        /// <summary>
                        /// 获取或设置商标申请时间。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("trademark_application_time")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("trademark_application_time")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Converters.RegularNullableDateTimeOffsetConverter))]
                        public DateTimeOffset? TrademarkApplicationTime { get; set; }

                        /// <summary>
                        /// 获取或设置海关进口货物报关单图片 URL 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("imported_goods_form")]
                        [System.Text.Json.Serialization.JsonPropertyName("imported_goods_form")]
                        public IList<string>? ImportedGoodsFormUrlList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置营业执照或组织机构代码证图片 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("license")]
                [System.Text.Json.Serialization.JsonPropertyName("license")]
                public string LicenseUrl { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置品牌信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_info")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_info")]
                public Types.Brand Brand { get; set; } = new Types.Brand();
            }
        }

        /// <summary>
        /// 获取或设置审核单信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("audit_req")]
        [System.Text.Json.Serialization.JsonPropertyName("audit_req")]
        public Types.Audit Audit { get; set; } = new Types.Audit();
    }
}
