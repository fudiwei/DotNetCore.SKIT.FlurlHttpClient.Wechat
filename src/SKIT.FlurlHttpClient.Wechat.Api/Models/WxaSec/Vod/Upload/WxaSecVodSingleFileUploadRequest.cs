using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/singlefileupload 接口的请求。</para>
    /// </summary>
    public class WxaSecVodSingleFileUploadRequest : WechatApiRequest, IInferable<WxaSecVodSingleFileUploadRequest, WxaSecVodSingleFileUploadResponse>
    {
        /// <summary>
        /// 获取或设置视频名称。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MediaName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频格式。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string MediaType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置视频文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] MediaFileBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置视频封面图片格式。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? CoverType { get; set; }

        /// <summary>
        /// 获取或设置视频封面文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[]? CoverFileBytes { get; set; }

        /// <summary>
        /// 获取或设置来源上下文。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? SourceContext { get; set; }
    }
}
