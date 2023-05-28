using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/sec/vod/uploadpart 接口的请求。</para>
    /// </summary>
    public class WxaSecVodUploadPartRequest : WechatApiRequest, IInferable<WxaSecVodUploadPartRequest, WxaSecVodSingleFileUploadResponse>
    {
        /// <summary>
        /// 获取或设置分片上传 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string UploadId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置分片编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PartNumber { get; set; }

        /// <summary>
        /// 获取或设置分片文件资源类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int FileType { get; set; }

        /// <summary>
        /// 获取或设置分片文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();
    }
}
