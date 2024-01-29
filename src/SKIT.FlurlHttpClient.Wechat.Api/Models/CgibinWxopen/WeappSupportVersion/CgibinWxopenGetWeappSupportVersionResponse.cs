namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /cgi-bin/wxopen/getweappsupportversion 接口的响应。</para>
    /// </summary>
    public class CgibinWxopenGetWeappSupportVersionResponse : WechatApiResponse
    {
        public static class Types
        {
            public class SdkVersionList
            {
                /// <summary>
                /// 获取或设置基础库版本列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("items")]
                [System.Text.Json.Serialization.JsonPropertyName("items")]
                public SdkVersionItem[] Items { get; set; } = default!;
            }

            public class SdkVersionItem
            {
                /// <summary>
                /// 获取或设置基础库版本。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("version")]
                [System.Text.Json.Serialization.JsonPropertyName("version")]
                public string SdkVersion { get; set; } = default!;

                /// <summary>
                /// 获取或设置用户分布百分比。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("percentage")]
                [System.Text.Json.Serialization.JsonPropertyName("percentage")]
                public decimal Percentage { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置当前基础库版本。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("now_version")]
        [System.Text.Json.Serialization.JsonPropertyName("now_version")]
        public string NowSdkVersion { get; set; } = default!;

        /// <summary>
        /// 获取或设置基础库版本列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uv_info")]
        [System.Text.Json.Serialization.JsonPropertyName("uv_info")]
        public Types.SdkVersionList SdkVersionList { get; set; } = default!;
    }
}
