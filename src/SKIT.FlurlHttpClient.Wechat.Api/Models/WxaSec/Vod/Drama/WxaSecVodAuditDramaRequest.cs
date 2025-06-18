using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/auditdrama 接口的请求。</para>
    /// </summary>
    public class WxaSecVodAuditDramaRequest : WechatApiRequest, IInferable<WxaSecVodAuditDramaRequest, WxaSecVodAuditDramaResponse>
    {
        public static class Types
        {
            public class ReplaceMedia
            {
                /// <summary>
                /// 获取或设置旧媒资文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("old")]
                [System.Text.Json.Serialization.JsonPropertyName("old")]
                public long OldMediaId { get; set; }
                
                /// <summary>
                /// 获取或设置新媒资文件 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("new")]
                [System.Text.Json.Serialization.JsonPropertyName("new")]
                public long NewMediaId { get; set; }
            }

            public class ActorList
            {
                /// <summary>
                /// 获取或设置演员列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("actor")]
                [System.Text.Json.Serialization.JsonPropertyName("actor")]
                public IList<ActorItem> Items { get; set; } = new List<ActorItem>();
            }

            public class ActorItem
            {
                /// <summary>
                /// 获取或设置演员姓名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置演员照片 MediaId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("photo_material_id")]
                [System.Text.Json.Serialization.JsonPropertyName("photo_material_id")]
                public string PhotoMediaId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置饰演角色。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("role")]
                [System.Text.Json.Serialization.JsonPropertyName("role")]
                public string Role { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置演员简介。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("profile")]
                [System.Text.Json.Serialization.JsonPropertyName("profile")]
                public string Profile { get; set; } = string.Empty;
            }
        }
    
        /// <summary>
        /// 获取或设置剧目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("drama_id")]
        [System.Text.Json.Serialization.JsonPropertyName("drama_id")]
        public long? DramaId { get; set; }

        /// <summary>
        /// 获取或设置剧名。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置描述。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("description")]
        [System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 获取或设置媒资文件数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_count")]
        [System.Text.Json.Serialization.JsonPropertyName("media_count")]
        public int? MediaCount { get; set; }

        /// <summary>
        /// 获取或设置媒资文件 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id_list")]
        public IList<long>? MediaIdList { get; set; }

        /// <summary>
        /// 获取或设置剧目推荐语。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("recommendations")]
        [System.Text.Json.Serialization.JsonPropertyName("recommendations")]
        public string? Recommendations { get; set; }

        /// <summary>
        /// 获取或设置制作方。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("producer")]
        [System.Text.Json.Serialization.JsonPropertyName("producer")]
        public string? Producer { get; set; }

        /// <summary>
        /// 获取或设置编剧。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("playwright")]
        [System.Text.Json.Serialization.JsonPropertyName("playwright")]
        public string? Playwright { get; set; }

        /// <summary>
        /// 获取或设置演员列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("actor_list")]
        [System.Text.Json.Serialization.JsonPropertyName("actor_list")]
        public Types.ActorList? ActorList { get; set; }

        /// <summary>
        /// 获取或设置封面图片 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_material_id")]
        public string? CoverMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置推广海报 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("promotion_poster_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("promotion_poster_material_id")]
        public string? PromotionPosterMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置剧目播放授权材料 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_material_id")]
        public string? AuthorizationMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置剧目资质类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_type")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_type")]
        public int? QualificationType { get; set; }

        /// <summary>
        /// 获取或设置剧目资质证明文件 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("qualification_certificate_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("qualification_certificate_material_id")]
        public string? QualificationCertificateMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置成本配置比例情况报告 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost_commitment_letter_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cost_commitment_letter_material_id")]
        public string? CostCommitmentLetterMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置剧目制作成本（单位：万元）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cost_of_production")]
        [System.Text.Json.Serialization.JsonPropertyName("cost_of_production")]
        public int? CostOfProduction { get; set; }
        
        /// <summary>
        /// 获取或设置剧目备案号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_number")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_number")]
        public string? RegistrationNumber { get; set; }

        /// <summary>
        /// 获取或设置广播电视节目制作经营许可证编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("production_license")]
        [System.Text.Json.Serialization.JsonPropertyName("production_license")]
        public string? ProductionLicenseNumber { get; set; }

        /// <summary>
        /// 获取或设置网络剧片发行许可证编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_license")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_license")]
        public string? PublishLicenseNumber { get; set; }

        /// <summary>
        /// 获取或设置其他材料 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other_material_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("other_material_material_id")]
        public string? OtherMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置是否加急审核。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("expedited")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("expedited")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
        public bool? IsExpedited { get; set; }

        /// <summary>
        /// 获取或设置替换的剧集信息列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("replace_media_list")]
        [System.Text.Json.Serialization.JsonPropertyName("replace_media_list")]
        public IList<Types.ReplaceMedia>? ReplaceMediaList { get; set; }
    }
}
