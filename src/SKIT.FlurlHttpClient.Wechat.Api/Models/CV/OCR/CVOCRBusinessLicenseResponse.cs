namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cv/ocr/bizlicense 接口的响应。</para>
    /// </summary>
    public class CVOCRBusinessLicenseResponse : WechatApiResponse
    {
        public static class Types
        {
            public class CertificationPosition
            {
                public static class Types
                {
                    public class Position : CVImageQrcodeResponse.Types.CodeResult.Types.Position
                    {
                    }
                }

                /// <summary>
                /// 获取或设置识别坐标信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("pos")]
                [System.Text.Json.Serialization.JsonPropertyName("pos")]
                public Types.Position Position { get; set; } = default!;
            }

            public class ImageSize : CVImageQrcodeResponse.Types.ImageSize
            {
            }
        }

        /// <summary>
        /// 获取或设置注册号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reg_num")]
        [System.Text.Json.Serialization.JsonPropertyName("reg_num")]
        public string RegistrationNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serial")]
        [System.Text.Json.Serialization.JsonPropertyName("serial")]
        public string SerialNumber { get; set; } = default!;

        /// <summary>
        /// 获取或设置法定代表人姓名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legal_representative")]
        [System.Text.Json.Serialization.JsonPropertyName("legal_representative")]
        public string LegalRepresentative { get; set; } = default!;

        /// <summary>
        /// 获取或设置组成形式。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type_of_organization")]
        [System.Text.Json.Serialization.JsonPropertyName("type_of_organization")]
        public string OrganizationType { get; set; } = default!;

        /// <summary>
        /// 获取或设置企业名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("enterprise_name")]
        [System.Text.Json.Serialization.JsonPropertyName("enterprise_name")]
        public string EnterpriseName { get; set; } = default!;

        /// <summary>
        /// 获取或设置公司类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("type_of_enterprise")]
        [System.Text.Json.Serialization.JsonPropertyName("type_of_enterprise")]
        public string EnterpriseType { get; set; } = default!;

        /// <summary>
        /// 获取或设置经营场所或企业住所。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("address")]
        [System.Text.Json.Serialization.JsonPropertyName("address")]
        public string Address { get; set; } = default!;

        /// <summary>
        /// 获取或设置经营范围。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_scope")]
        [System.Text.Json.Serialization.JsonPropertyName("business_scope")]
        public string BusinessScope { get; set; } = default!;

        /// <summary>
        /// 获取或设置注册资本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_capital")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_capital")]
        public string RegisteredCapital { get; set; } = default!;

        /// <summary>
        /// 获取或设置实收资本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("paid_in_capital")]
        [System.Text.Json.Serialization.JsonPropertyName("paid_in_capital")]
        public string? PaidInCapital { get; set; }

        /// <summary>
        /// 获取或设置营业期限。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valid_period")]
        [System.Text.Json.Serialization.JsonPropertyName("valid_period")]
        public string ValidDate { get; set; } = default!;

        /// <summary>
        /// 获取或设置注册日期。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registered_date")]
        [System.Text.Json.Serialization.JsonPropertyName("registered_date")]
        public string RegisteredDate { get; set; } = default!;

        /// <summary>
        /// 获取或设置营业执照位置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cert_position")]
        [System.Text.Json.Serialization.JsonPropertyName("cert_position")]
        public Types.CertificationPosition? CertificationPosition { get; set; }

        /// <summary>
        /// 获取或设置图片大小信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("img_size")]
        [System.Text.Json.Serialization.JsonPropertyName("img_size")]
        public Types.ImageSize ImageSize { get; set; } = default!;
    }
}
