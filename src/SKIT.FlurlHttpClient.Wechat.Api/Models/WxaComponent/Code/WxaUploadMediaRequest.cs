using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/uploadmedia 接口的请求。</para>
    /// </summary>
    public class WxaUploadMediaRequest : WechatApiRequest, IInferable<WxaUploadMediaRequest, WxaUploadMediaResponse>
    {
        /// <summary>
        /// 获取或设置文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] FileBytes { get; set; } = Array.Empty<byte>();

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
    }
}
