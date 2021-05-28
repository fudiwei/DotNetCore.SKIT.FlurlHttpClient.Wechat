using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/voice/queryrecoresultfortext 接口的请求。</para>
    /// </summary>
    public class CgibinMediaVoiceQueryRecognitionResultForTextRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置语音唯一标识。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string VoiceId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置语言。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Language { get; set; }
    }
}
