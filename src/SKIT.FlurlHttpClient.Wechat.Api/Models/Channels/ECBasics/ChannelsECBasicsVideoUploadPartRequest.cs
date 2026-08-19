using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/basics/video/uploadpart 接口的请求。</para>
    /// </summary>
    public class ChannelsECBasicsVideoUploadPartRequest : WechatApiRequest, IInferable<ChannelsECBasicsVideoUploadPartRequest, ChannelsECBasicsVideoUploadPartResponse>
    {
        /// <summary>
        /// 获取或设置文件上传标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string VideoUploadKey { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置块编号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int PartNumber { get; set; }

        /// <summary>
        /// 获取或设置文件块字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();
    }
}
