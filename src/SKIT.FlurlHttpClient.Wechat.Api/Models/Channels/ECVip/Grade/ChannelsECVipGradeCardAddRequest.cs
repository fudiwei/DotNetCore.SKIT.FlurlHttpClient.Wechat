namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/vip/grade/card/add 接口的请求。</para>
    /// </summary>
    public class ChannelsECVipGradeCardAddRequest : WechatApiRequest, IInferable<ChannelsECVipGradeCardAddRequest, ChannelsECVipGradeCardAddResponse>
    {
        /// <summary>
        /// 获取或设置会员等级。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grade")]
        [System.Text.Json.Serialization.JsonPropertyName("grade")]
        public int Grade { get; set; }

        /// <summary>
        /// 获取或设置会员等级名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 获取或设置经验值门槛。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("experience_value_threshold")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("experience_value_threshold")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int ExperienceValueThreshold { get; set; }

        /// <summary>
        /// 获取或设置经验值倍数（×10）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("experience_value_multiple")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.Common.TextualNumberConverter))]
        [System.Text.Json.Serialization.JsonPropertyName("experience_value_multiple")]
        [System.Text.Json.Serialization.JsonNumberHandling(System.Text.Json.Serialization.JsonNumberHandling.AllowReadingFromString | System.Text.Json.Serialization.JsonNumberHandling.WriteAsString)]
        public int ExperienceValueMultiple { get; set; }
    }
}
