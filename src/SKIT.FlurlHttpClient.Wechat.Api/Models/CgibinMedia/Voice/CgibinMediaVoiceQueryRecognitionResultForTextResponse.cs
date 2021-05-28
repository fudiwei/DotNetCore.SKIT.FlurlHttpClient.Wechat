using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/media/voice/queryrecoresultfortext 接口的响应。</para>
    /// </summary>
    public class CgibinMediaVoiceQueryRecognitionResultForTextResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置识别结果。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("result")]
        [System.Text.Json.Serialization.JsonPropertyName("result")]
        public string Result { get; set; } = default!;
    }
}
