using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/famousbrand/apply 接口的请求。</para>
    /// </summary>
    public class WxaSecFamousBrandApplyRequest : WechatApiRequest, IInferable<WxaSecFamousBrandApplyRequest, WxaSecFamousBrandApplyResponse>
    {
        public static class Types
        {
            public class Application
            {
                public static class Types
                {
                    public class AuditInfo
                    {
                        /// <summary>
                        /// 获取或设置品牌名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_name")]
                        public string BrandName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置品牌类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("brand_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("brand_type")]
                        public int BrandType { get; set; }

                        /// <summary>
                        /// 获取或设置电商平台旗舰店。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("flagship_in_which_ec_platform")]
                        [System.Text.Json.Serialization.JsonPropertyName("flagship_in_which_ec_platform")]
                        public string? FlagshipInWhichECPlatform { get; set; }

                        /// <summary>
                        /// 获取或设置电商平台旗舰店佐证材料 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ec_platform_proof_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("ec_platform_proof_list")]
                        public IList<string>? ECPlatformProofMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置其他补充说明材料 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("other_material_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("other_material_list")]
                        public IList<string>? OtherMaterialMediaIdList { get; set; }

                        /// <summary>
                        /// 获取或设置有关部门认定的驰名商标佐证材料 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("authority_certified_proof_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("authority_certified_proof_list")]
                        public IList<string>? AuthorityCertifiedProofMediaIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置品牌申请类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("apply_for")]
                [System.Text.Json.Serialization.JsonPropertyName("apply_for")]
                public int ApplyForType { get; set; }

                /// <summary>
                /// 获取或设置品牌信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("audit_info")]
                [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
                public Types.AuditInfo? AuditInfo { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置申请信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Application")]
        [System.Text.Json.Serialization.JsonPropertyName("Application")]
        public Types.Application Application { get; set; } = new Types.Application();
    }
}
