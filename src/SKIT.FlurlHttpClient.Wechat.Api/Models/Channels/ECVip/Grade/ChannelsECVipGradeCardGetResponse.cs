namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/vip/grade/card/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipGradeCardGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class ExperienceValueConfig
                    {
                        public static class Types
                        {
                            public class PayAmountRule
                            {
                                /// <summary>
                                /// 获取或设置消费金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_value")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? PayAmount { get; set; }

                                /// <summary>
                                /// 获取或设置消费门槛金额（单位：分）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_amount_floor")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_amount_floor")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? PayAmountFloor { get; set; }

                                /// <summary>
                                /// 获取或设置获得的经验值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gain_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("gain_value")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? GainExperienceValue { get; set; }
                            }

                            public class PayTimesRule
                            {
                                /// <summary>
                                /// 获取或设置获得的经验值。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gain_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("gain_value")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? GainExperienceValue { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置消费金额规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount_rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount_rule")]
                        public Types.PayAmountRule? PayAmountRule { get; set; }

                        /// <summary>
                        /// 获取或设置消费次数规则信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_time_rule")]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_time_rule")]
                        public Types.PayTimesRule? PayTimesRule { get; set; }
                    }

                    public class GradeCardConfig
                    {
                        public static class Types
                        {
                            public class GradeCard
                            {
                                public static class Types
                                {
                                    public class AuditInfo
                                    {
                                        /// <summary>
                                        /// 获取或设置审核状态。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("status")]
                                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                                        public int Status { get; set; }

                                        /// <summary>
                                        /// 获取或设置最新会员等级名称。
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("latest_name")]
                                        [System.Text.Json.Serialization.JsonPropertyName("latest_name")]
                                        public string? LatestName { get; set; }
                                    }
                                }

                                /// <summary>
                                /// 获取或设置会员等级。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("grade")]
                                [System.Text.Json.Serialization.JsonPropertyName("grade")]
                                public int Grade { get; set; }

                                /// <summary>
                                /// 获取或设置会员等级名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("valid_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("valid_name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置经验值门槛。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("experience_value_threshold")]
                                [System.Text.Json.Serialization.JsonPropertyName("experience_value_threshold")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int ExperienceValueThreshold { get; set; }

                                /// <summary>
                                /// 获取或设置经验值倍数（×10）。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("experience_value_multiple")]
                                [System.Text.Json.Serialization.JsonPropertyName("experience_value_multiple")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int ExperienceValueMultiple { get; set; }

                                /// <summary>
                                /// 获取或设置审核信息。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("audit_info")]
                                [System.Text.Json.Serialization.JsonPropertyName("audit_info")]
                                public Types.AuditInfo? AuditInfo { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置会员等级列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("grade_card_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("grade_card_list")]
                        public Types.GradeCard[] GradeCardList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置经验值配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("experience_value_conf")]
                [System.Text.Json.Serialization.JsonPropertyName("experience_value_conf")]
                public Types.ExperienceValueConfig? ExperienceValueConfig { get; set; }

                /// <summary>
                /// 获取或设置会员等级配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("card_conf")]
                [System.Text.Json.Serialization.JsonPropertyName("card_conf")]
                public Types.GradeCardConfig? GradeCardConfig { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("info")]
        [System.Text.Json.Serialization.JsonPropertyName("info")]
        public Types.Data Data { get; set; } = default!;
    }
}
