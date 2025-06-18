namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getversioninfo 接口的响应。</para>
    /// </summary>
    public class WxaGetVersionInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ExperienceInfo
            {
                /// <summary>
                /// 获取或设置提交时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_time")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置版本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_version")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_version")]
                public string Version { get; set; } = default!;

                /// <summary>
                /// 获取或设置版本描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_desc")]
                public string Description { get; set; } = default!;
            }

            public class ReleaseInfo
            {
                /// <summary>
                /// 获取或设置发布时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_time")]
                [System.Text.Json.Serialization.JsonPropertyName("release_time")]
                public long Timestamp { get; set; }

                /// <summary>
                /// 获取或设置版本信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_version")]
                [System.Text.Json.Serialization.JsonPropertyName("release_version")]
                public string Version { get; set; } = default!;

                /// <summary>
                /// 获取或设置版本描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("release_desc")]
                public string Description { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置体验版信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("exp_info")]
        public Types.ExperienceInfo? ExperienceInfo { get; set; }

        /// <summary>
        /// 获取或设置线上版信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("release_info")]
        [System.Text.Json.Serialization.JsonPropertyName("release_info")]
        public Types.ReleaseInfo? ReleaseInfo { get; set; }
    }
}
