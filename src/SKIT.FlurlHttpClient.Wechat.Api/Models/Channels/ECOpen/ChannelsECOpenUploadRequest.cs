namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/open/upload 接口的请求。</para>
    /// </summary>
    public class ChannelsECOpenUploadRequest : WechatApiRequest, IInferable<ChannelsECOpenUploadRequest, ChannelsECOpenUploadResponse>
    {
        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置返回数据类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upload_type")]
        [System.Text.Json.Serialization.JsonPropertyName("upload_type")]
        public int UploadType { get; set; }

        /// <summary>
        /// 获取或设置文件字节数组。与字段 <see cref="FileUrl"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[]? FileBytes { get; set; }

        /// <summary>
        /// 获取或设置文件名。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileName { get; set; }

        /// <summary>
        /// 获取或设置文件 Conent-Type。如果不指定将由系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? FileContentType { get; set; }

        /// <summary>
        /// 获取或设置文件 URL。与字段 <see cref="FileBytes"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("file_url")]
        [System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }
    }
}
