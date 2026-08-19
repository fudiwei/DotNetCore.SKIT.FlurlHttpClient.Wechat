namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/video/initupload 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsVideoInitUploadRequest : WechatApiRequest, IInferable<ChannelsECBasicsVideoInitUploadRequest, ChannelsECBasicsVideoInitUploadResponse>
    {
        /// <summary>
        /// 获取或设置上传场景类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_type")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_type")]
        public int SceneType { get; set; }

        /// <summary>
        /// 获取或设置文件类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_type")]
        [System.Text.Json.Serialization.JsonPropertyName("file_type")]
        public string FileType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置文件大小（单位：字节）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_size")]
        [System.Text.Json.Serialization.JsonPropertyName("file_size")]
        public int FileSize { get; set; }
    }
}
