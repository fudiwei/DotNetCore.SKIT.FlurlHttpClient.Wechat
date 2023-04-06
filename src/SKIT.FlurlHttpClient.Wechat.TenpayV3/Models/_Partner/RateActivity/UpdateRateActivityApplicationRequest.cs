using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PATCH] /rate-activity/applications/id/{application_id} 接口的请求。</para>
    /// </summary>
    public class UpdateRateActivityApplicationRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class ActivityDetail
            {
                public static class Types
                {
                    public class Material : CreateRateActivityApplicationRequest.Types.ActivityDetail.Types.Material
                    {
                    }
                }

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

            public class AdditionalInfomation : CreateRateActivityApplicationRequest.Types.AdditionalInfomation
            {
            }
        }

        /// <summary>
        /// 获取或设置申请单编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置报名活动详情。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activity_detail_modification")]
        [System.Text.Json.Serialization.JsonPropertyName("activity_detail_modification")]
        public Types.ActivityDetail? ActivityDetail { get; set; }

        /// <summary>
        /// 获取或设置补充信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("additional_information")]
        [System.Text.Json.Serialization.JsonPropertyName("additional_information")]
        public Types.AdditionalInfomation? AdditionalInfomation { get; set; }
    }
}
