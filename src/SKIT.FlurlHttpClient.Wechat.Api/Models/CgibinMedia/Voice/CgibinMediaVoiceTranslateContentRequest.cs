using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/voice/translatecontent 接口的请求。</para>
    /// </summary>
    public class CgibinMediaVoiceTranslateContentRequest : WechatApiRequest, IMapResponse<CgibinMediaVoiceTranslateContentRequest, CgibinMediaVoiceTranslateContentResponse>
    {
        /// <summary>
        /// 获取或设置语音文件字节数组。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public byte[] VoiceBytes { get; set; } = new byte[0];

        /// <summary>
        /// 获取或设置源语言。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string FromLanguage { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置目标语言。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ToLanguage { get; set; } = string.Empty;
    }
}
