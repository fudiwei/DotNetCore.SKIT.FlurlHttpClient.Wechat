namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /componenttcb/staticfilelist 接口的响应。</para>
    /// </summary>
    public class ComponentTCBStaticFileListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class File : ComponentTCBGetBucketResponse.Types.File
            {
            }
        }


        /// <summary>
        /// 获取或设置网站列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contents")]
        [System.Text.Json.Serialization.JsonPropertyName("contents")]
        public Types.File[] FileList { get; set; } = default!;

        /// <summary>
        /// 获取或设置内容是否被截断。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_truncated")]
        [System.Text.Json.Serialization.JsonPropertyName("is_truncated")]
        public bool IsTruncated { get; set; }
    }
}
