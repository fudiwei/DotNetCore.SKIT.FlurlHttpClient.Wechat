namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /channels/ec/vip/score/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECVipScoreGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Config
            {
                public static class Types
                {
                    public class GainRule
                    {
                        public static class Types
                        {
                            public class PayAmountRule
                            {
                                /// <summary>
                                /// 获取或设置消费积分。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pay_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("pay_value")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? PayValue { get; set; }
                            }

                            public class PayTimesRule
                            {
                                /// <summary>
                                /// 获取或设置获得积分。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gain_value")]
                                [System.Text.Json.Serialization.JsonPropertyName("gain_value")]
                                [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                                public int? GainValue { get; set; }
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

                    public class DeductRule
                    {
                        /// <summary>
                        /// 获取或设置是否开启。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("open_mgr")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.NumericalBooleanConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("open_mgr")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalBooleanConverter))]
                        public bool IsOpen { get; set; }

                        /// <summary>
                        /// 获取或设置抵扣比例（单位：百分数）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("ratio")]
                        [System.Text.Json.Serialization.JsonPropertyName("ratio")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? Ratio { get; set; }

                        /// <summary>
                        /// 获取或设置抵扣上限。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("limit")]
                        [System.Text.Json.Serialization.JsonPropertyName("limit")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString)]
                        public int? Limit { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置获取规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("gain_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("gain_rule")]
                public Types.GainRule? GainRule { get; set; }

                /// <summary>
                /// 获取或设置抵扣规则信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("deduct_rule")]
                [System.Text.Json.Serialization.JsonPropertyName("deduct_rule")]
                public Types.DeductRule? DeductRule { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conf")]
        [System.Text.Json.Serialization.JsonPropertyName("conf")]
        public Types.Config Config { get; set; } = default!;
    }
}
