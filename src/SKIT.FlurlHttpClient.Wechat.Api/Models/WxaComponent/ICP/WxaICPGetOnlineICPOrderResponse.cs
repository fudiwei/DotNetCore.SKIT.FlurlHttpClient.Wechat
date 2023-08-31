namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/icp/get_online_icp_order 接口的响应。</para>
    /// </summary>
    public class WxaICPGetOnlineICPOrderResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Subject
            {
                public static class Types
                {
                    public class BaseInfo
                    {
                        /// <summary>
                        /// 获取或设置主体性质。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置单位名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备案省份代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string ProvinceCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备案城市代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string CityCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备案县区代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("district")]
                        [System.Text.Json.Serialization.JsonPropertyName("district")]
                        public string DistrictCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置通讯地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment")]
                        public string? Comment { get; set; }
                    }

                    public class PersonalInfo
                    {
                        /// <summary>
                        /// 获取或设置临时居住证明照片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("residence_permit")]
                        [System.Text.Json.Serialization.JsonPropertyName("residence_permit")]
                        public string? ResidencePermitMediaId { get; set; }
                    }

                    public class OrganizeInfo
                    {
                        /// <summary>
                        /// 获取或设置证件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_type")]
                        public int CertificateType { get; set; }

                        /// <summary>
                        /// 获取或设置证件号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_number")]
                        public string CertificateNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_address")]
                        public string CertificateAddress { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件照片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_photo")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_photo")]
                        public string? CertificatePhotoMediaId { get; set; }
                    }

                    public class PrincipalInfo
                    {
                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置手机号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("mobile")]
                        [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                        public string MobileNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置电子邮件。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("email")]
                        [System.Text.Json.Serialization.JsonPropertyName("email")]
                        public string Email { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置应急联系方式。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("emergency_contact")]
                        [System.Text.Json.Serialization.JsonPropertyName("emergency_contact")]
                        public string EmergencyContact { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_type")]
                        public int CertificateType { get; set; }

                        /// <summary>
                        /// 获取或设置证件号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_number")]
                        public string CertificateNumber { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置有效期起始日期（格式：yyyyMMdd）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_validity_date_start")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_validity_date_start")]
                        public string CertificateValidityStartDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置有效期终止日期（格式：yyyyMMdd / "长期"）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_validity_date_end")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_validity_date_end")]
                        public string CertificateValidityEndDateString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件正面照片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_photo_front")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_photo_front")]
                        public string CertificatePhotoFrontMediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件背面照片 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_photo_back")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_photo_back")]
                        public string CertificatePhotoBackMediaId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置授权书 MediaId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authorization_letter")]
                        [System.Text.Json.Serialization.JsonPropertyName("authorization_letter")]
                        public string? AuthorizationLetterMediaId { get; set; }

                        /// <summary>
                        /// 获取或设置扫脸认证任务 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("verify_task_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("verify_task_id")]
                        public string? VerifyTaskIdMediaId { get; set; }
                    }

                    public class LegalPersonInfo
                    {
                        /// <summary>
                        /// 获取或设置姓名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置证件号码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("certificate_number")]
                        [System.Text.Json.Serialization.JsonPropertyName("certificate_number")]
                        public string CertificateNumber { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo BaseInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置个人主体额外信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("personal_info")]
                [System.Text.Json.Serialization.JsonPropertyName("personal_info")]
                public Types.PersonalInfo? PersonalInfo { get; set; }

                /// <summary>
                /// 获取或设置企业主体额外信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("organize_info")]
                [System.Text.Json.Serialization.JsonPropertyName("organize_info")]
                public Types.OrganizeInfo? OrganizeInfo { get; set; }

                /// <summary>
                /// 获取或设置主体负责人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("principal_info")]
                [System.Text.Json.Serialization.JsonPropertyName("principal_info")]
                public Types.PrincipalInfo PrincipalInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置法人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("legal_person_info")]
                [System.Text.Json.Serialization.JsonPropertyName("legal_person_info")]
                public Types.LegalPersonInfo? LegalPersonInfo { get; set; }
            }

            public class MiniProgram
            {
                public static class Types
                {
                    public class BaseInfo
                    {
                        public static class Types
                        {
                            public class NrlxDetail
                            {
                                /// <summary>
                                /// 获取或设置前置审批类型。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("type")]
                                [System.Text.Json.Serialization.JsonPropertyName("type")]
                                public int Type { get; set; }

                                /// <summary>
                                /// 获取或设置前置审批号。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("code")]
                                [System.Text.Json.Serialization.JsonPropertyName("code")]
                                public string? Code { get; set; }

                                /// <summary>
                                /// 获取或设置前置审批材料 MediaId。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("media")]
                                [System.Text.Json.Serialization.JsonPropertyName("media")]
                                public string? MediaId { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置小程序 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("appid")]
                        public string AppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置小程序名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("name")]
                        [System.Text.Json.Serialization.JsonPropertyName("name")]
                        public string Name { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置服务内容类型列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("service_content_types")]
                        [System.Text.Json.Serialization.JsonPropertyName("service_content_types")]
                        public int[] ServiceContentTypeList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置前置审批列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nrlx_details")]
                        [System.Text.Json.Serialization.JsonPropertyName("nrlx_details")]
                        public Types.NrlxDetail[]? NrlxDetailList { get; set; }

                        /// <summary>
                        /// 获取或设置备注。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("comment")]
                        [System.Text.Json.Serialization.JsonPropertyName("comment")]
                        public string? Comment { get; set; }
                    }

                    public class PrincipalInfo : Subject.Types.PrincipalInfo
                    {
                    }
                }

                /// <summary>
                /// 获取或设置基本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_info")]
                public Types.BaseInfo BaseInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置负责人信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("principal_info")]
                [System.Text.Json.Serialization.JsonPropertyName("principal_info")]
                public Types.PrincipalInfo PrincipalInfo { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置备案主体信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icp_subject")]
        [System.Text.Json.Serialization.JsonPropertyName("icp_subject")]
        public Types.Subject Subject { get; set; } = default!;

        /// <summary>
        /// 获取或设置小程序信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("icp_applets")]
        [System.Text.Json.Serialization.JsonPropertyName("icp_applets")]
        public Types.MiniProgram MiniProgram { get; set; } = default!;
    }
}
