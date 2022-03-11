using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/voice/addvoicetorecofortext 接口的请求。</para>
    /// </summary>
    public class CgibinMediaVoiceAddVoiceToRecognitionForTextRequest : WechatApiRequest, IInferable<CgibinMediaVoiceAddVoiceToRecognitionForTextRequest, CgibinMediaVoiceAddVoiceToRecognitionForTextResponse>
    {
        /// <summary>
        /// 获取或设置文件格式。
        /// <para>默认值：mp3</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string Format { get; set; } = "mp3";

        /// <summary>
        /// 获取或设置语音唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string VoiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置语音文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] VoiceBytes { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// 获取或设置语言。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Language { get; set; }
    }
}
