namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/oa/vacation/getcorpconf 接口的响应。</para>
    /// </summary>
    public class CgibinOAVacationGetCorpConfigResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class Vacation
            {
                public static class Types
                {
                    public class Quota
                    {
                        /// <summary>
                        /// 获取或设置假期发放类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("type")]
                        [System.Text.Json.Serialization.JsonPropertyName("type")]
                        public int Type { get; set; }

                        /// <summary>
                        /// 获取或设置自动发放时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("autoreset_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("autoreset_time")]
                        public long? AutoResetTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置自动发放时长（单位：秒）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("autoreset_duration")]
                        [System.Text.Json.Serialization.JsonPropertyName("autoreset_duration")]
                        public int? AutoResetDuration { get; set; }
                    }
                }

                /// <summary>
                /// 获取或设置假期类型标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public int VacationId { get; set; }

                /// <summary>
                /// 获取或设置假期名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;

                /// <summary>
                /// 获取或设置时长计算类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("duration_type")]
                [System.Text.Json.Serialization.JsonPropertyName("duration_type")]
                public int DurationType { get; set; }

                /// <summary>
                /// 获取或设置假期时间刻度。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("time_attr")]
                [System.Text.Json.Serialization.JsonPropertyName("time_attr")]
                public int TimeType { get; set; }

                /// <summary>
                /// 获取或设置假期发放相关配置信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("quota_attr")]
                [System.Text.Json.Serialization.JsonPropertyName("quota_attr")]
                public Types.Quota Quota { get; set; } = default!;

                /// <summary>
                /// 获取或设置一天对应的秒数。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("perday_duration")]
                [System.Text.Json.Serialization.JsonPropertyName("perday_duration")]
                public int DurationPerDay { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置假期列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lists")]
        [System.Text.Json.Serialization.JsonPropertyName("lists")]
        public Types.Vacation[] VacationList { get; set; } = default!;
    }
}
