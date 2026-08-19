namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/video/initupload 接口的响应。</para>
    /// </summary>
    public class ChannelsECBasicsVideoInitUploadResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件上传标识。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("video_upload_key")]
                [System.Text.Json.Serialization.JsonPropertyName("video_upload_key")]
                public string VideoUploadKey { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
