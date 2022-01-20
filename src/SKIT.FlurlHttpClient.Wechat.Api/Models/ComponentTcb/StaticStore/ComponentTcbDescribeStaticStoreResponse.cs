namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/describestaticstore 接口的响应。</para>
    /// </summary>
    public class ComponentTcbDescribeStaticStoreResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Website
            {
                /// <summary>
                /// 获取或设置环境 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("env")]
                [System.Text.Json.Serialization.JsonPropertyName("env")]
                public string EnvironmentId { get; set; } = default!;

                /// <summary>
                /// 获取或设置域名。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("domain")]
                [System.Text.Json.Serialization.JsonPropertyName("domain")]
                public string Domain { get; set; } = default!;

                /// <summary>
                /// 获取或设置存储桶。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bucket")]
                [System.Text.Json.Serialization.JsonPropertyName("bucket")]
                public string Bucket { get; set; } = default!;

                /// <summary>
                /// 获取或设置区域。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("regoin")]
                [System.Text.Json.Serialization.JsonPropertyName("regoin")]
                public string Region { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public string Status { get; set; } = default!;
            }
        }


        /// <summary>
        /// 获取或设置网站列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Website[] WebsiteList { get; set; } = default!;
    }
}
