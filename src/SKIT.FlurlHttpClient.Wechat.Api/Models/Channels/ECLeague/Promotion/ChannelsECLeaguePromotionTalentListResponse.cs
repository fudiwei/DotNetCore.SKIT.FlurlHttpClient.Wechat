namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/league/promotion/talent/list 接口的响应。</para>
    /// </summary>
    public class ChannelsECLeaguePromotionTalentListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Talent
            {
                public static class Types
                {
                    public class BaseInfo
                    {
                        /// <summary>
                        /// 获取或设置带货达人 AppId。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("talent_appid")]
                        [System.Text.Json.Serialization.JsonPropertyName("talent_appid")]
                        public string TalentAppId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置带货达人昵称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置带货达人头像 URL。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("head_img")]
                        [System.Text.Json.Serialization.JsonPropertyName("head_img")]
                        public string HeadImageUrl { get; set; } = default!;
                    }

                    public class CommissionInfo
                    {
                        /// <summary>
                        /// 获取或设置推广计划 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_plan_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_id")]
                        public long PromotionPlanId { get; set; }

                        /// <summary>
                        /// 获取或设置推广计划类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promotion_plan_type")]
                        [System.Text.Json.Serialization.JsonPropertyName("promotion_plan_type")]
                        public int PromotionPlanType { get; set; }

                        /// <summary>
                        /// 获取或设置佣金率（单位：万分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                        public int CommissionRatio { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置基础信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("base_talent_info")]
                [System.Text.Json.Serialization.JsonPropertyName("base_talent_info")]
                public Types.BaseInfo BaseInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置佣金信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commission_info")]
                [System.Text.Json.Serialization.JsonPropertyName("commission_info")]
                public Types.CommissionInfo CommissionInfo { get; set; } = default!;

                /// <summary>
                /// 获取或设置推广状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("talent_relation_status")]
                [System.Text.Json.Serialization.JsonPropertyName("talent_relation_status")]
                public int TalentRelationStatus { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置带货达人列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("list")]
        [System.Text.Json.Serialization.JsonPropertyName("list")]
        public Types.Talent[] TalentList { get; set; } = default!;

        /// <summary>
        /// 获取或设置推广计划总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 获取或设置是否还有更多。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("continue_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("continue_flag")]
        public bool HasMore { get; set; }
    }
}
