using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [POST] /rate-activity/applications 接口的请求。</para>
    /// </summary>
    public class CreateRateActivityApplicationRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ActivityDetail
            {
                public static class Types
                {
                    public class Material
                    {
                        /// <summary>
                        /// 获取或设置材料 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_material_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_material_id")]
                        public string? MaterialId { get; set; }

                        /// <summary>
                        /// 获取或设置材料 MediaId 列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("apply_material_information")]
                        [System.Text.Json.Serialization.JsonPropertyName("apply_material_information")]
                        public IList<string>? MaterialMediaIdList { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置活动 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_id")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_id")]
                public string ActivityId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置活动费率字符串。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_rate")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_rate")]
                public string? ActivityRateString { get; set; }

                /// <summary>
                /// 获取或设置申请材料列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("activity_apply_information")]
                [System.Text.Json.Serialization.JsonPropertyName("activity_apply_information")]
                public IList<Types.Material>? MaterialList { get; set; }
            }

            public class AdditionalInfomation
            {
                /// <summary>
                /// 获取或设置补充说明。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("additional_message")]
                [System.Text.Json.Serialization.JsonPropertyName("additional_message")]
                public string? AdditionalMessage { get; set; }

                /// <summary>
                /// 获取或设置补充材料 MediaId 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("additional_material")]
                [System.Text.Json.Serialization.JsonPropertyName("additional_material")]
                public IList<string>? AdditionalMaterialMediaIdList { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置从业机构号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("acquiring_bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("acquiring_bank_id")]
        public string AcquiringBankId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string ChannelId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置从业机构特约商户号	。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置报名活动详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_detail")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_detail")]
        public Types.ActivityDetail ActivityDetail { get; set; } = new Types.ActivityDetail();

        /// <summary>
        /// 获取或设置补充信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_information")]
        [System.Text.Json.Serialization.JsonPropertyName("additional_information")]
        public Types.AdditionalInfomation? AdditionalInfomation { get; set; }
    }
}
