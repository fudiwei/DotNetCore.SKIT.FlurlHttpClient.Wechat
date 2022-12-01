namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /wxa/revertcoderelease 接口的响应。</para>
    /// </summary>
    public class WxaRevertCodeReleaseResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Release
            {
                /// <summary>
                /// 获取或设置小程序版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("app_version")]
                [System.Text.Json.Serialization.JsonPropertyName("app_version")]
                public int AppVersion { get; set; }

                /// <summary>
                /// 获取或设置用户自定义版本号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_version")]
                [System.Text.Json.Serialization.JsonPropertyName("user_version")]
                public string UserVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户自定义版本描述。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("user_desc")]
                [System.Text.Json.Serialization.JsonPropertyName("user_desc")]
                public string UserDescription { get; set; } = default!;

                /// <summary>
                /// 获取或设置提交时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("commit_time")]
                [System.Text.Json.Serialization.JsonPropertyName("commit_time")]
                public long CommitTimestamp { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置发布版本列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version_list")]
        [System.Text.Json.Serialization.JsonPropertyName("version_list")]
        public Types.Release[]? ReleaseList { get; set; }
    }
}
