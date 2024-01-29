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
        /// 获取或设置封面图片 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cover_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("cover_material_id")]
        public string? CoverMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置广播电视节目制作经营许可证 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("production_license_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("production_license_material_id")]
        public string? ProductionLicenseMaterialMediaId { get; set; }

        /// <summary>
        /// 获取或设置剧目播放授权材料 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("authorized_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("authorized_material_id")]
        public string? AuthorizationMaterialMediaId { get; set; }
        
        /// <summary>
        /// 获取或设置剧目备案号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_number")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_number")]
        public string? RegistrationNumber { get; set; }
        
        /// <summary>
        /// 获取或设置网络剧片发行许可证编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_license")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_license")]
        public string? PublishLicenseNumber { get; set; }
        
        /// <summary>
        /// 获取或设置网络剧片发行许可证图片 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publish_license_material_id")]
        [System.Text.Json.Serialization.JsonPropertyName("publish_license_material_id")]
        public string? PublishLicenseMaterialMediaId { get; set; }
        
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
