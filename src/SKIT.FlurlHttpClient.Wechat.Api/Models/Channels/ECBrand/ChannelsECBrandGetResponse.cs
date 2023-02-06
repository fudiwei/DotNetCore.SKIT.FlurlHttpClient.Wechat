namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/brand/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECBrandGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Brand
            {
                public static class Types
                {
                    public class RegisterDetail
                    {
                        /// <summary>
                        /// 获取或设置商标注册人。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("registrant")]
                        [System.Text.Json.Serialization.JsonPropertyName("registrant")]
                        public string? Registrant { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("register_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("register_no")]
                        public string? RegisterNumber { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册有效期开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long? StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册有效期结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long? EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否长期有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_permanent")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_permanent")]
                        public bool IsPermanent { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册证的文件 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("register_certifications")]
                        [System.Text.Json.Serialization.JsonPropertyName("register_certifications")]
                        public string[] RegisterCertificationFileIdList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置变更/续展证明的文件 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("renew_certifications")]
                        [System.Text.Json.Serialization.JsonPropertyName("renew_certifications")]
                        public string[]? RenewCertificationFileIdList { get; set; }
                    }

                    public class ApplicationDetail
                    {
                        /// <summary>
                        /// 获取或设置商标申请号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acceptance_no")]
                        [System.Text.Json.Serialization.JsonPropertyName("acceptance_no")]
                        public string? AcceptanceNumber { get; set; }

                        /// <summary>
                        /// 获取或设置商标申请受理时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acceptance_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("acceptance_time")]
                        public long? AcceptanceTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置商标注册申请受理书的文件 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acceptance_certification")]
                        [System.Text.Json.Serialization.JsonPropertyName("acceptance_certification")]
                        public string[]? AcceptanceCertificationFileIdList { get; set; }
                    }

                    public class GrantDetail
                    {
                        /// <summary>
                        /// 获取或设置授权级数。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grant_level")]
                        [System.Text.Json.Serialization.JsonPropertyName("grant_level")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? GrantLevel { get; set; }

                        /// <summary>
                        /// 获取或设置授权有效期开始时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("start_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("start_time")]
                        public long? StartTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置授权有效期结束时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("end_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("end_time")]
                        public long? EndTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置是否长期有效。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("is_permanent")]
                        [System.Text.Json.Serialization.JsonPropertyName("is_permanent")]
                        public bool IsPermanent { get; set; }

                        /// <summary>
                        /// 获取或设置品牌销售授权书的文件 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grant_certifications")]
                        [System.Text.Json.Serialization.JsonPropertyName("grant_certifications")]
                        public string[]? GrantCertificationFileIdList { get; set; }

                        /// <summary>
                        /// 获取或设置品牌权利人证件照的文件 ID 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_owner_id_photos")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_owner_id_photos")]
                        public string[]? BrandOwnerIdPhotoFileIdList { get; set; }
                    }

                    public class AuditResult
                    {
                        /// <summary>
                        /// 获取或设置审核单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("audit_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("audit_id")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public long AuditId { get; set; }

                        /// <summary>
                        /// 获取或设置审核拒绝原因。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("reject_reason")]
                        [System.Text.Json.Serialization.JsonPropertyName("reject_reason")]
                        public string? RejectReason { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置品牌 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("brand_id")]
                [System.Text.Json.Serialization.JsonPropertyName("brand_id")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public long BrandId { get; set; }

                /// <summary>
                /// 获取或设置品牌商标中文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("ch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("ch_name")]
                public string? ChineseName { get; set; }

                /// <summary>
                /// 获取或设置品牌商标英文名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("en_name")]
                [System.Text.Json.Serialization.JsonPropertyName("en_name")]
                public string? EnglishName { get; set; }

                /// <summary>
                /// 获取或设置商标分类号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("classification_no")]
                [System.Text.Json.Serialization.JsonPropertyName("classification_no")]
                public string ClassificationNumber { get; set; } = default!;

                /// <summary>
                /// 获取或设置商标类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("trade_mark_symbol")]
                [System.Text.Json.Serialization.JsonPropertyName("trade_mark_symbol")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int TradeMarkSymbol { get; set; }

                /// <summary>
                /// 获取或设置商标注册详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("register_details")]
                [System.Text.Json.Serialization.JsonPropertyName("register_details")]
                public Types.RegisterDetail RegisterDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置商标申请详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("application_details")]
                [System.Text.Json.Serialization.JsonPropertyName("application_details")]
                public Types.ApplicationDetail ApplicationDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置商标授权类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_type")]
                [System.Text.Json.Serialization.JsonPropertyName("grant_type")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int GrantType { get; set; }

                /// <summary>
                /// 获取或设置商标授权详细信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("grant_details")]
                [System.Text.Json.Serialization.JsonPropertyName("grant_details")]
                public Types.GrantDetail GrantDetail { get; set; } = default!;

                /// <summary>
                /// 获取或设置申请状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("create_time")]
                public long CreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置更新时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("update_time")]
                [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                public long UpdateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置审核结果。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_result")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_result")]
                public Types.AuditResult? AuditResult { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置品牌信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("brand")]
        [System.Text.Json.Serialization.JsonPropertyName("brand")]
        public Types.Brand Brand { get; set; } = default!;
    }
}
