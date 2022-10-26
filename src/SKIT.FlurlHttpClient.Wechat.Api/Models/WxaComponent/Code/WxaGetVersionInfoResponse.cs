namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/getversioninfo 接口的响应。</para>
    /// </summary>
    public class WxaGetVersionInfoResponse : WechatApiResponse
    {
        public static class Types
        {
            public class ExpInfo
            {
                /// <summary>
                /// 提交体验版的时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_time")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_time")]
                public long ExpTime { get; set; }

                /// <summary>
                /// 体验版版本信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_version")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_version")]
                public string ExpVersion { get; set; }

                /// <summary>
                /// 体验版版本描述
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exp_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("exp_desc")]
                public string ExpDesc { get; set; }
            }
            public class ReleaseInfo
            {
                /// <summary>
                /// 发布线上版的时间。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_time")]
                [System.Text.Json.Serialization.JsonPropertyName("release_time")]
                public long ReleaseTime { get; set; }

                /// <summary>
                /// 线上版版本信息
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_version")]
                [System.Text.Json.Serialization.JsonPropertyName("release_version")]
                public string ReleaseVersion { get; set; }

                /// <summary>
                /// 线上版本描述
                /// </summary>
                [Newtonsoft.Json.JsonProperty("release_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("release_desc")]
                public string ReleaseDesc { get; set; }
            }
        }

        /// <summary>
        /// 体验版信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exp_info")]
        [System.Text.Json.Serialization.JsonPropertyName("exp_info")]
        public Types.ExpInfo ExpInfo { get; set; } = default!;

        /// <summary>
        /// 线上版信息
        /// </summary>
        [Newtonsoft.Json.JsonProperty("release_info")]
        [System.Text.Json.Serialization.JsonPropertyName("release_info")]
        public Types.ReleaseInfo ReleaseInfo { get; set; } = default!;
    }
}
