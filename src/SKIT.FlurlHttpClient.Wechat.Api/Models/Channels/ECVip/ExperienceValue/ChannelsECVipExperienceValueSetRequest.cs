namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/experiencevalue/set 接口的请求。</para>
    /// </summary>
    public class ChannelsECVipExperienceValueSetRequest : WechatApiRequest, IInferable<ChannelsECVipExperienceValueSetRequest, ChannelsECVipExperienceValueSetResponse>
    {
        public static class Types
        {
            public class Config
            {
                public static class Types
                {
                    public class PayAmountRule
                    {
                        /// <summary>
                        /// 获取或设置消费金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_value")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_value")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public int? PayAmount { get; set; }

                        /// <summary>
                        /// 获取或设置消费门槛金额（单位：分）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pay_amount_floor")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("pay_amount_floor")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public int? PayAmountFloor { get; set; }

                        /// <summary>
                        /// 获取或设置获得的经验值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gain_value")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("gain_value")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
                        public int? GainExperienceValue { get; set; }
                    }

                    public class PayTimesRule
                    {
                        /// <summary>
                        /// 获取或设置获得的经验值。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gain_value")]
                        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
                        [System.Text.Json.Serialization.JsonPropertyName("gain_value")]
                        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
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
        }

        /// <summary>
        /// 获取或设置配置信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conf")]
        [System.Text.Json.Serialization.JsonPropertyName("conf")]
        public Types.Config Config { get; set; } = new Types.Config();
    }
}
